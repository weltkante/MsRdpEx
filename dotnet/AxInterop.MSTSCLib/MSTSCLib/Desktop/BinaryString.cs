using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;
using MSTSCLib;

#nullable enable

// Using this namespace is a trick so we don't have to make using directives conditional.
namespace System.Runtime.InteropServices.Marshalling
{
    public unsafe sealed class BinaryStringMarshaler : ICustomMarshaler
    {
        public static ICustomMarshaler GetInstance(string cookie) => new BinaryStringMarshaler();

        public object? MarshalNativeToManaged(IntPtr pointer)
        {
            if (pointer == IntPtr.Zero)
                return null;

            // make sure we don't construct a BinaryString larger than .NET can manage
            // (it's safe to throw here, the marshaller retains ownership and frees it)
            if (((int*)pointer)[-1] < 0)
                throw new OverflowException();

            // transfer ownership to managed code
            return new BinaryString(pointer);
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            var value = (BinaryString)ManagedObj;
            if (value is null)
                return IntPtr.Zero;

            var pointer = value.pointer;
            value.pointer = 0;

            // we are using zero pointers in non-null BinaryString as a cheap representation of an empty BinaryString
            // however if we need to pass ownership of an empty string to native code we actually have to allocate one
            if (pointer == 0 && (pointer = BinaryStringInterop.AllocateByteBuffer(null, 0)) == 0)
                throw new OutOfMemoryException();

            return pointer;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeBSTR(pNativeData);
        }

        public int GetNativeDataSize()
        {
            throw new NotImplementedException();
        }
    }
}

//namespace MSTSCLib

public sealed unsafe partial class BinaryString : IDisposable, IEquatable<BinaryString>
{
    //public static implicit operator ReadOnlyBinaryStringRef(BinaryString? bstr) => bstr is null ? default : new(bstr.AsByteSpan());
    public static implicit operator string?(BinaryString? bstr) => bstr?.ToString();
    //public static implicit operator ReadOnlySpan<char>(BinaryString? bstr) => bstr is null ? default : bstr.AsTextSpan();
    //public static implicit operator ReadOnlySpan<byte>(BinaryString? bstr) => bstr is null ? default : bstr.AsByteSpan();

    public static implicit operator BinaryString?(string? text) => text is null ? null : new(text);
    public static implicit operator BinaryString(char[] text) => new(text, 0, text?.Length ?? 0);
    public static implicit operator BinaryString(byte[] data) => new(data, 0, data?.Length ?? 0);
    //public static implicit operator BinaryString(Span<char> text) => new(text);
    //public static implicit operator BinaryString(Span<byte> data) => new(data);
    //public static implicit operator BinaryString(ReadOnlySpan<char> text) => new(text);
    //public static implicit operator BinaryString(ReadOnlySpan<byte> data) => new(data);

    public static BinaryString Empty { get; } = new(0);

    public static BinaryString AllocateByteLength(int length)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length));

        if (length == 0)
            return Empty;

        var pointer = BinaryStringInterop.AllocateByteBuffer(null, length);
        if (pointer == 0)
            throw new OutOfMemoryException();

        return new(pointer);
    }

    public static BinaryString AllocateTextLength(int length)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length));

        if (length == 0)
            return Empty;

        var pointer = BinaryStringInterop.AllocateTextBuffer(null, length);
        if (pointer == 0)
            throw new OutOfMemoryException();

        return new(pointer);
    }

    internal nint pointer;

    internal BinaryString(nint pointer)
    {
        if ((this.pointer = pointer) == 0)
            GC.SuppressFinalize(this);
    }

    public BinaryString(byte[] data, int offset, int length)
    {
        if (length == 0)
        {
            GC.SuppressFinalize(this);
        }
        else
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            if (offset < 0 || offset > data.Length)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (length < 0 || length > data.Length - offset)
                throw new ArgumentOutOfRangeException(nameof(length));

            fixed (byte* dataPointer = data)
                if ((this.pointer = BinaryStringInterop.AllocateByteBuffer(dataPointer + offset, length)) == 0)
                    throw new OutOfMemoryException();
        }
    }

    public BinaryString(char[] text, int offset, int length)
    {
        if (length == 0)
        {
            GC.SuppressFinalize(this);
        }
        else
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            if (offset < 0 || offset > text.Length)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (length < 0 || length > text.Length - offset)
                throw new ArgumentOutOfRangeException(nameof(length));

            fixed (char* textPointer = text)
                if ((this.pointer = BinaryStringInterop.AllocateTextBuffer(textPointer + offset, length)) == 0)
                    throw new OutOfMemoryException();
        }
    }

    public BinaryString(string? text)
    {
        if (string.IsNullOrEmpty(text))
            GC.SuppressFinalize(this);
        else
            pointer = Marshal.StringToBSTR(text);
    }

    ~BinaryString()
    {
        Dispose();
    }

    public void Dispose()
    {
        var pointer = Interlocked.Exchange(ref this.pointer, default);
        if (pointer != default)
        {
            GC.SuppressFinalize(this);
            Marshal.FreeBSTR(pointer);
        }
    }

    public int ByteLength => pointer == 0 ? 0 : ((int*)pointer)[-1];
    public int TextLength => ByteLength / 2;
    public bool IsEmpty => ByteLength == 0;
    public bool IsDisposed => pointer == 0;

    //public Span<byte> AsByteSpan() => pointer == 0 ? new(Array.Empty<byte>()) : new((void*)pointer, ByteLength);
    //public Span<char> AsTextSpan() => pointer == 0 ? new(Array.Empty<char>()) : new((void*)pointer, TextLength);
    public override string ToString() => new((char*)pointer, 0, TextLength);
    public override int GetHashCode()
    {
        throw new NotImplementedException();
        //var hash = new HashCode();
        //hash.AddBytes(AsByteSpan());
        //return hash.ToHashCode();
    }
    public override bool Equals(object? obj) => Equals(obj as BinaryString);
    public bool Equals(BinaryString? other) => throw new NotImplementedException(); //other is not null && (this.pointer == other.pointer || this.AsByteSpan().SequenceEqual(other.AsByteSpan()));
    public static bool operator ==(BinaryString lhs, BinaryString rhs) => lhs is null ? rhs is null : lhs.Equals(rhs);
    public static bool operator !=(BinaryString lhs, BinaryString rhs) => !(lhs == rhs);
}

internal static unsafe class BinaryStringInterop
{
    [DllImport("oleaut32", EntryPoint = "SysAllocStringLen", ExactSpelling = true, SetLastError = false, CharSet = CharSet.Unicode)]
    public static extern nint AllocateTextBuffer( // WINOLEAUTAPI_(_Ret_writes_maybenull_z_(ui+1) BSTR) SysAllocStringLen
        char* buffer, // _In_reads_opt_(ui) const OLECHAR * strIn
        int length); // UINT ui

    [DllImport("oleaut32", EntryPoint = "SysAllocStringByteLen", ExactSpelling = true, SetLastError = false, CharSet = CharSet.Unicode)]
    public static extern nint AllocateByteBuffer( // WINOLEAUTAPI_(BSTR) SysAllocStringByteLen
        byte* buffer, // _In_opt_z_ LPCSTR psz
        int length); // _In_ UINT len
}
