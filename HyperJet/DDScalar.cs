#pragma warning disable IDE0017

namespace HyperJet;

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD1Scalar : IScalar, IEquatable<DD1Scalar>, IComparable<DD1Scalar>
{
    public double Constant;
    public double D0;
    public double D0D0;

    public DD1Scalar()
    {
    }

    public DD1Scalar(double constant)
    {
        Constant = constant;
    }

    public DD1Scalar(double constant, double d0, double d0d0)
    {
        Constant = constant;
        D0 = d0;
        D0D0 = d0d0;
    }
    
    public DD1Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D0D0 = data[2];
    }

    public static DD1Scalar Variable(double constant)
    {
        var result = new DD1Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public double Evaluate(double d0)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        result += d0 * tmp0;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD1Scalar lhs, DD1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD1Scalar);
	}

	public bool Equals(DD1Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD1Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 1;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 3);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 3)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 1)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 1)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (1 - i) * i / 2 + j
            : (1 - j) * j / 2 + i;

		if (idx >= 1)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar Forward(double constant, double da, double dada, DD1Scalar a)
    {
        var result = new DD1Scalar(constant);
        result.D0 = da * a.D0;

        var ca0 = dada * a.D0;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD1Scalar a, DD1Scalar b)
    {
        var result = new DD1Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD1Scalar a, DD1Scalar b, DD1Scalar c)
    {
        var result = new DD1Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator -(DD1Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator +(DD1Scalar lhs, DD1Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator +(double lhs, DD1Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator +(DD1Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator -(DD1Scalar lhs, DD1Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator -(double lhs, DD1Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator -(DD1Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator *(DD1Scalar lhs, DD1Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator *(double lhs, DD1Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator *(DD1Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator /(DD1Scalar lhs, DD1Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator /(double lhs, DD1Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD1Scalar operator /(DD1Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD2Scalar : IScalar, IEquatable<DD2Scalar>, IComparable<DD2Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D0D0;
    public double D0D1;
    public double D1D1;

    public DD2Scalar()
    {
    }

    public DD2Scalar(double constant)
    {
        Constant = constant;
    }

    public DD2Scalar(double constant, double d0, double d1, double d0d0, double d0d1, double d1d1)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D1D1 = d1d1;
    }
    
    public DD2Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D0D0 = data[3];
        D0D1 = data[4];
        D1D1 = data[5];
    }

    public static DD2Scalar Variable0(double constant)
    {
        var result = new DD2Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD2Scalar Variable1(double constant)
    {
        var result = new DD2Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static (DD2Scalar, DD2Scalar) Variables(double constant0, double constant1)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);

        return (variable0, variable1);
    }

    public double Evaluate(double d0, double d1)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        result += d1 * tmp1;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD2Scalar lhs, DD2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD2Scalar);
	}

	public bool Equals(DD2Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD2Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 2;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 6);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 6)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 2)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 3)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (3 - i) * i / 2 + j
            : (3 - j) * j / 2 + i;

		if (idx >= 3)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar Forward(double constant, double da, double dada, DD2Scalar a)
    {
        var result = new DD2Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD2Scalar a, DD2Scalar b)
    {
        var result = new DD2Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD2Scalar a, DD2Scalar b, DD2Scalar c)
    {
        var result = new DD2Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator -(DD2Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator +(DD2Scalar lhs, DD2Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator +(double lhs, DD2Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator +(DD2Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator -(DD2Scalar lhs, DD2Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator -(double lhs, DD2Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator -(DD2Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator *(DD2Scalar lhs, DD2Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator *(double lhs, DD2Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator *(DD2Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator /(DD2Scalar lhs, DD2Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator /(double lhs, DD2Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD2Scalar operator /(DD2Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD3Scalar : IScalar, IEquatable<DD3Scalar>, IComparable<DD3Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D1D1;
    public double D1D2;
    public double D2D2;

    public DD3Scalar()
    {
    }

    public DD3Scalar(double constant)
    {
        Constant = constant;
    }

    public DD3Scalar(double constant, double d0, double d1, double d2, double d0d0, double d0d1, double d0d2, double d1d1, double d1d2, double d2d2)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D2D2 = d2d2;
    }
    
    public DD3Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D0D0 = data[4];
        D0D1 = data[5];
        D0D2 = data[6];
        D1D1 = data[7];
        D1D2 = data[8];
        D2D2 = data[9];
    }

    public static DD3Scalar Variable0(double constant)
    {
        var result = new DD3Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD3Scalar Variable1(double constant)
    {
        var result = new DD3Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD3Scalar Variable2(double constant)
    {
        var result = new DD3Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static (DD3Scalar, DD3Scalar, DD3Scalar) Variables(double constant0, double constant1, double constant2)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);

        return (variable0, variable1, variable2);
    }

    public double Evaluate(double d0, double d1, double d2)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        result += d2 * tmp2;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD3Scalar lhs, DD3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD3Scalar);
	}

	public bool Equals(DD3Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD3Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 3;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 10);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 10)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 3)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 6)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (5 - i) * i / 2 + j
            : (5 - j) * j / 2 + i;

		if (idx >= 6)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar Forward(double constant, double da, double dada, DD3Scalar a)
    {
        var result = new DD3Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD3Scalar a, DD3Scalar b)
    {
        var result = new DD3Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD3Scalar a, DD3Scalar b, DD3Scalar c)
    {
        var result = new DD3Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator -(DD3Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator +(DD3Scalar lhs, DD3Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator +(double lhs, DD3Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator +(DD3Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator -(DD3Scalar lhs, DD3Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator -(double lhs, DD3Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator -(DD3Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator *(DD3Scalar lhs, DD3Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator *(double lhs, DD3Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator *(DD3Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator /(DD3Scalar lhs, DD3Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator /(double lhs, DD3Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD3Scalar operator /(DD3Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD4Scalar : IScalar, IEquatable<DD4Scalar>, IComparable<DD4Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D2D2;
    public double D2D3;
    public double D3D3;

    public DD4Scalar()
    {
    }

    public DD4Scalar(double constant)
    {
        Constant = constant;
    }

    public DD4Scalar(double constant, double d0, double d1, double d2, double d3, double d0d0, double d0d1, double d0d2, double d0d3, double d1d1, double d1d2, double d1d3, double d2d2, double d2d3, double d3d3)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D3D3 = d3d3;
    }
    
    public DD4Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D0D0 = data[5];
        D0D1 = data[6];
        D0D2 = data[7];
        D0D3 = data[8];
        D1D1 = data[9];
        D1D2 = data[10];
        D1D3 = data[11];
        D2D2 = data[12];
        D2D3 = data[13];
        D3D3 = data[14];
    }

    public static DD4Scalar Variable0(double constant)
    {
        var result = new DD4Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD4Scalar Variable1(double constant)
    {
        var result = new DD4Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD4Scalar Variable2(double constant)
    {
        var result = new DD4Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD4Scalar Variable3(double constant)
    {
        var result = new DD4Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static (DD4Scalar, DD4Scalar, DD4Scalar, DD4Scalar) Variables(double constant0, double constant1, double constant2, double constant3)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);

        return (variable0, variable1, variable2, variable3);
    }

    public double Evaluate(double d0, double d1, double d2, double d3)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        result += d3 * tmp3;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD4Scalar lhs, DD4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD4Scalar);
	}

	public bool Equals(DD4Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD4Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 4;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 15);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 15)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 4)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 10)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (7 - i) * i / 2 + j
            : (7 - j) * j / 2 + i;

		if (idx >= 10)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar Forward(double constant, double da, double dada, DD4Scalar a)
    {
        var result = new DD4Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD4Scalar a, DD4Scalar b)
    {
        var result = new DD4Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD4Scalar a, DD4Scalar b, DD4Scalar c)
    {
        var result = new DD4Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator -(DD4Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator +(DD4Scalar lhs, DD4Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator +(double lhs, DD4Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator +(DD4Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator -(DD4Scalar lhs, DD4Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator -(double lhs, DD4Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator -(DD4Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator *(DD4Scalar lhs, DD4Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator *(double lhs, DD4Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator *(DD4Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator /(DD4Scalar lhs, DD4Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator /(double lhs, DD4Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD4Scalar operator /(DD4Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD5Scalar : IScalar, IEquatable<DD5Scalar>, IComparable<DD5Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D3D3;
    public double D3D4;
    public double D4D4;

    public DD5Scalar()
    {
    }

    public DD5Scalar(double constant)
    {
        Constant = constant;
    }

    public DD5Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d1d1, double d1d2, double d1d3, double d1d4, double d2d2, double d2d3, double d2d4, double d3d3, double d3d4, double d4d4)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D4D4 = d4d4;
    }
    
    public DD5Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D0D0 = data[6];
        D0D1 = data[7];
        D0D2 = data[8];
        D0D3 = data[9];
        D0D4 = data[10];
        D1D1 = data[11];
        D1D2 = data[12];
        D1D3 = data[13];
        D1D4 = data[14];
        D2D2 = data[15];
        D2D3 = data[16];
        D2D4 = data[17];
        D3D3 = data[18];
        D3D4 = data[19];
        D4D4 = data[20];
    }

    public static DD5Scalar Variable0(double constant)
    {
        var result = new DD5Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD5Scalar Variable1(double constant)
    {
        var result = new DD5Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD5Scalar Variable2(double constant)
    {
        var result = new DD5Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD5Scalar Variable3(double constant)
    {
        var result = new DD5Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD5Scalar Variable4(double constant)
    {
        var result = new DD5Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static (DD5Scalar, DD5Scalar, DD5Scalar, DD5Scalar, DD5Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);

        return (variable0, variable1, variable2, variable3, variable4);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        result += d4 * tmp4;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD5Scalar lhs, DD5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD5Scalar);
	}

	public bool Equals(DD5Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD5Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 5;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 21);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 21)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 5)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 15)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (9 - i) * i / 2 + j
            : (9 - j) * j / 2 + i;

		if (idx >= 15)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar Forward(double constant, double da, double dada, DD5Scalar a)
    {
        var result = new DD5Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD5Scalar a, DD5Scalar b)
    {
        var result = new DD5Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD5Scalar a, DD5Scalar b, DD5Scalar c)
    {
        var result = new DD5Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator -(DD5Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator +(DD5Scalar lhs, DD5Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator +(double lhs, DD5Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator +(DD5Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator -(DD5Scalar lhs, DD5Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator -(double lhs, DD5Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator -(DD5Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator *(DD5Scalar lhs, DD5Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator *(double lhs, DD5Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator *(DD5Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator /(DD5Scalar lhs, DD5Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator /(double lhs, DD5Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD5Scalar operator /(DD5Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD6Scalar : IScalar, IEquatable<DD6Scalar>, IComparable<DD6Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D4D4;
    public double D4D5;
    public double D5D5;

    public DD6Scalar()
    {
    }

    public DD6Scalar(double constant)
    {
        Constant = constant;
    }

    public DD6Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d2d2, double d2d3, double d2d4, double d2d5, double d3d3, double d3d4, double d3d5, double d4d4, double d4d5, double d5d5)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D5D5 = d5d5;
    }
    
    public DD6Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D0D0 = data[7];
        D0D1 = data[8];
        D0D2 = data[9];
        D0D3 = data[10];
        D0D4 = data[11];
        D0D5 = data[12];
        D1D1 = data[13];
        D1D2 = data[14];
        D1D3 = data[15];
        D1D4 = data[16];
        D1D5 = data[17];
        D2D2 = data[18];
        D2D3 = data[19];
        D2D4 = data[20];
        D2D5 = data[21];
        D3D3 = data[22];
        D3D4 = data[23];
        D3D5 = data[24];
        D4D4 = data[25];
        D4D5 = data[26];
        D5D5 = data[27];
    }

    public static DD6Scalar Variable0(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD6Scalar Variable1(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD6Scalar Variable2(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD6Scalar Variable3(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD6Scalar Variable4(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD6Scalar Variable5(double constant)
    {
        var result = new DD6Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static (DD6Scalar, DD6Scalar, DD6Scalar, DD6Scalar, DD6Scalar, DD6Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);

        return (variable0, variable1, variable2, variable3, variable4, variable5);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        result += d5 * tmp5;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD6Scalar lhs, DD6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD6Scalar);
	}

	public bool Equals(DD6Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD6Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 6;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 28);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 28)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 6)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 21)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (11 - i) * i / 2 + j
            : (11 - j) * j / 2 + i;

		if (idx >= 21)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar Forward(double constant, double da, double dada, DD6Scalar a)
    {
        var result = new DD6Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD6Scalar a, DD6Scalar b)
    {
        var result = new DD6Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD6Scalar a, DD6Scalar b, DD6Scalar c)
    {
        var result = new DD6Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator -(DD6Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator +(DD6Scalar lhs, DD6Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator +(double lhs, DD6Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator +(DD6Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator -(DD6Scalar lhs, DD6Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator -(double lhs, DD6Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator -(DD6Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator *(DD6Scalar lhs, DD6Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator *(double lhs, DD6Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator *(DD6Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator /(DD6Scalar lhs, DD6Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator /(double lhs, DD6Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD6Scalar operator /(DD6Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD7Scalar : IScalar, IEquatable<DD7Scalar>, IComparable<DD7Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D5D5;
    public double D5D6;
    public double D6D6;

    public DD7Scalar()
    {
    }

    public DD7Scalar(double constant)
    {
        Constant = constant;
    }

    public DD7Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d3d3, double d3d4, double d3d5, double d3d6, double d4d4, double d4d5, double d4d6, double d5d5, double d5d6, double d6d6)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D6D6 = d6d6;
    }
    
    public DD7Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D0D0 = data[8];
        D0D1 = data[9];
        D0D2 = data[10];
        D0D3 = data[11];
        D0D4 = data[12];
        D0D5 = data[13];
        D0D6 = data[14];
        D1D1 = data[15];
        D1D2 = data[16];
        D1D3 = data[17];
        D1D4 = data[18];
        D1D5 = data[19];
        D1D6 = data[20];
        D2D2 = data[21];
        D2D3 = data[22];
        D2D4 = data[23];
        D2D5 = data[24];
        D2D6 = data[25];
        D3D3 = data[26];
        D3D4 = data[27];
        D3D5 = data[28];
        D3D6 = data[29];
        D4D4 = data[30];
        D4D5 = data[31];
        D4D6 = data[32];
        D5D5 = data[33];
        D5D6 = data[34];
        D6D6 = data[35];
    }

    public static DD7Scalar Variable0(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD7Scalar Variable1(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD7Scalar Variable2(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD7Scalar Variable3(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD7Scalar Variable4(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD7Scalar Variable5(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD7Scalar Variable6(double constant)
    {
        var result = new DD7Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static (DD7Scalar, DD7Scalar, DD7Scalar, DD7Scalar, DD7Scalar, DD7Scalar, DD7Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        result += d6 * tmp6;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD7Scalar lhs, DD7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD7Scalar);
	}

	public bool Equals(DD7Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD7Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 7;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 36);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 36)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 7)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 28)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (13 - i) * i / 2 + j
            : (13 - j) * j / 2 + i;

		if (idx >= 28)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar Forward(double constant, double da, double dada, DD7Scalar a)
    {
        var result = new DD7Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD7Scalar a, DD7Scalar b)
    {
        var result = new DD7Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD7Scalar a, DD7Scalar b, DD7Scalar c)
    {
        var result = new DD7Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator -(DD7Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator +(DD7Scalar lhs, DD7Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator +(double lhs, DD7Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator +(DD7Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator -(DD7Scalar lhs, DD7Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator -(double lhs, DD7Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator -(DD7Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator *(DD7Scalar lhs, DD7Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator *(double lhs, DD7Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator *(DD7Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator /(DD7Scalar lhs, DD7Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator /(double lhs, DD7Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD7Scalar operator /(DD7Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD8Scalar : IScalar, IEquatable<DD8Scalar>, IComparable<DD8Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D7;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D0D7;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D1D7;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D2D7;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D3D7;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D4D7;
    public double D5D5;
    public double D5D6;
    public double D5D7;
    public double D6D6;
    public double D6D7;
    public double D7D7;

    public DD8Scalar()
    {
    }

    public DD8Scalar(double constant)
    {
        Constant = constant;
    }

    public DD8Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d0d7, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d1d7, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d2d7, double d3d3, double d3d4, double d3d5, double d3d6, double d3d7, double d4d4, double d4d5, double d4d6, double d4d7, double d5d5, double d5d6, double d5d7, double d6d6, double d6d7, double d7d7)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D7 = d7;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D0D7 = d0d7;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D1D7 = d1d7;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D2D7 = d2d7;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D3D7 = d3d7;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D4D7 = d4d7;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D5D7 = d5d7;
        D6D6 = d6d6;
        D6D7 = d6d7;
        D7D7 = d7d7;
    }
    
    public DD8Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D7 = data[8];
        D0D0 = data[9];
        D0D1 = data[10];
        D0D2 = data[11];
        D0D3 = data[12];
        D0D4 = data[13];
        D0D5 = data[14];
        D0D6 = data[15];
        D0D7 = data[16];
        D1D1 = data[17];
        D1D2 = data[18];
        D1D3 = data[19];
        D1D4 = data[20];
        D1D5 = data[21];
        D1D6 = data[22];
        D1D7 = data[23];
        D2D2 = data[24];
        D2D3 = data[25];
        D2D4 = data[26];
        D2D5 = data[27];
        D2D6 = data[28];
        D2D7 = data[29];
        D3D3 = data[30];
        D3D4 = data[31];
        D3D5 = data[32];
        D3D6 = data[33];
        D3D7 = data[34];
        D4D4 = data[35];
        D4D5 = data[36];
        D4D6 = data[37];
        D4D7 = data[38];
        D5D5 = data[39];
        D5D6 = data[40];
        D5D7 = data[41];
        D6D6 = data[42];
        D6D7 = data[43];
        D7D7 = data[44];
    }

    public static DD8Scalar Variable0(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD8Scalar Variable1(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD8Scalar Variable2(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD8Scalar Variable3(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD8Scalar Variable4(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD8Scalar Variable5(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD8Scalar Variable6(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static DD8Scalar Variable7(double constant)
    {
        var result = new DD8Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static (DD8Scalar, DD8Scalar, DD8Scalar, DD8Scalar, DD8Scalar, DD8Scalar, DD8Scalar, DD8Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);
        var variable7 = Variable7(constant7);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6, variable7);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        tmp0 += d7 * D0D7;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        tmp1 += d7 * D1D7;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        tmp2 += d7 * D2D7;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        tmp3 += d7 * D3D7;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        tmp4 += d7 * D4D7;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        tmp5 += d7 * D5D7;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        tmp6 += d7 * D6D7;
        result += d6 * tmp6;

        var tmp7 = 0.0;
        tmp7 += d0 * D0D7;
        tmp7 += d1 * D1D7;
        tmp7 += d2 * D2D7;
        tmp7 += d3 * D3D7;
        tmp7 += d4 * D4D7;
        tmp7 += d5 * D5D7;
        tmp7 += d6 * D6D7;
        tmp7 += d7 * D7D7;
        result += d7 * tmp7;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;
        result += D7 * d7;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD8Scalar lhs, DD8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD8Scalar);
	}

	public bool Equals(DD8Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD8Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 8;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 45);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 45)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 8)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 36)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (15 - i) * i / 2 + j
            : (15 - j) * j / 2 + i;

		if (idx >= 36)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar Forward(double constant, double da, double dada, DD8Scalar a)
    {
        var result = new DD8Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;
        var ca7 = dada * a.D7;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D0D7 = da * a.D0D7 + ca0 * a.D7;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D1D7 = da * a.D1D7 + ca1 * a.D7;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D2D7 = da * a.D2D7 + ca2 * a.D7;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D3D7 = da * a.D3D7 + ca3 * a.D7;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D4D7 = da * a.D4D7 + ca4 * a.D7;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D5D7 = da * a.D5D7 + ca5 * a.D7;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;
        result.D6D7 = da * a.D6D7 + ca6 * a.D7;
        result.D7D7 = da * a.D7D7 + ca7 * a.D7;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD8Scalar a, DD8Scalar b)
    {
        var result = new DD8Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;
        var ca7 = dada * a.D7 + dadb * b.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD8Scalar a, DD8Scalar b, DD8Scalar c)
    {
        var result = new DD8Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;
        var ca7 = dada * a.D7 + dadb * b.D7 + dadc * c.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7 + dbdc * c.D7;
        var cc7 = dadc * a.D7 + dbdc * b.D7 + dcdc * c.D7;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + dc * c.D0D7 + ca0 * a.D7 + cb0 * b.D7 + cc0 * c.D7;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + dc * c.D1D7 + ca1 * a.D7 + cb1 * b.D7 + cc1 * c.D7;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + dc * c.D2D7 + ca2 * a.D7 + cb2 * b.D7 + cc2 * c.D7;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + dc * c.D3D7 + ca3 * a.D7 + cb3 * b.D7 + cc3 * c.D7;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + dc * c.D4D7 + ca4 * a.D7 + cb4 * b.D7 + cc4 * c.D7;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + dc * c.D5D7 + ca5 * a.D7 + cb5 * b.D7 + cc5 * c.D7;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + dc * c.D6D7 + ca6 * a.D7 + cb6 * b.D7 + cc6 * c.D7;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + dc * c.D7D7 + ca7 * a.D7 + cb7 * b.D7 + cc7 * c.D7;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator -(DD8Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator +(DD8Scalar lhs, DD8Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator +(double lhs, DD8Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator +(DD8Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator -(DD8Scalar lhs, DD8Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator -(double lhs, DD8Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator -(DD8Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator *(DD8Scalar lhs, DD8Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator *(double lhs, DD8Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator *(DD8Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator /(DD8Scalar lhs, DD8Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator /(double lhs, DD8Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD8Scalar operator /(DD8Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD9Scalar : IScalar, IEquatable<DD9Scalar>, IComparable<DD9Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D7;
    public double D8;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D0D7;
    public double D0D8;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D1D7;
    public double D1D8;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D2D7;
    public double D2D8;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D3D7;
    public double D3D8;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D4D7;
    public double D4D8;
    public double D5D5;
    public double D5D6;
    public double D5D7;
    public double D5D8;
    public double D6D6;
    public double D6D7;
    public double D6D8;
    public double D7D7;
    public double D7D8;
    public double D8D8;

    public DD9Scalar()
    {
    }

    public DD9Scalar(double constant)
    {
        Constant = constant;
    }

    public DD9Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d0d7, double d0d8, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d1d7, double d1d8, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d2d7, double d2d8, double d3d3, double d3d4, double d3d5, double d3d6, double d3d7, double d3d8, double d4d4, double d4d5, double d4d6, double d4d7, double d4d8, double d5d5, double d5d6, double d5d7, double d5d8, double d6d6, double d6d7, double d6d8, double d7d7, double d7d8, double d8d8)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D7 = d7;
        D8 = d8;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D0D7 = d0d7;
        D0D8 = d0d8;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D1D7 = d1d7;
        D1D8 = d1d8;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D2D7 = d2d7;
        D2D8 = d2d8;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D3D7 = d3d7;
        D3D8 = d3d8;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D4D7 = d4d7;
        D4D8 = d4d8;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D5D7 = d5d7;
        D5D8 = d5d8;
        D6D6 = d6d6;
        D6D7 = d6d7;
        D6D8 = d6d8;
        D7D7 = d7d7;
        D7D8 = d7d8;
        D8D8 = d8d8;
    }
    
    public DD9Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D7 = data[8];
        D8 = data[9];
        D0D0 = data[10];
        D0D1 = data[11];
        D0D2 = data[12];
        D0D3 = data[13];
        D0D4 = data[14];
        D0D5 = data[15];
        D0D6 = data[16];
        D0D7 = data[17];
        D0D8 = data[18];
        D1D1 = data[19];
        D1D2 = data[20];
        D1D3 = data[21];
        D1D4 = data[22];
        D1D5 = data[23];
        D1D6 = data[24];
        D1D7 = data[25];
        D1D8 = data[26];
        D2D2 = data[27];
        D2D3 = data[28];
        D2D4 = data[29];
        D2D5 = data[30];
        D2D6 = data[31];
        D2D7 = data[32];
        D2D8 = data[33];
        D3D3 = data[34];
        D3D4 = data[35];
        D3D5 = data[36];
        D3D6 = data[37];
        D3D7 = data[38];
        D3D8 = data[39];
        D4D4 = data[40];
        D4D5 = data[41];
        D4D6 = data[42];
        D4D7 = data[43];
        D4D8 = data[44];
        D5D5 = data[45];
        D5D6 = data[46];
        D5D7 = data[47];
        D5D8 = data[48];
        D6D6 = data[49];
        D6D7 = data[50];
        D6D8 = data[51];
        D7D7 = data[52];
        D7D8 = data[53];
        D8D8 = data[54];
    }

    public static DD9Scalar Variable0(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD9Scalar Variable1(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD9Scalar Variable2(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD9Scalar Variable3(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD9Scalar Variable4(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD9Scalar Variable5(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD9Scalar Variable6(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static DD9Scalar Variable7(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static DD9Scalar Variable8(double constant)
    {
        var result = new DD9Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static (DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar, DD9Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);
        var variable7 = Variable7(constant7);
        var variable8 = Variable8(constant8);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6, variable7, variable8);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        tmp0 += d7 * D0D7;
        tmp0 += d8 * D0D8;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        tmp1 += d7 * D1D7;
        tmp1 += d8 * D1D8;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        tmp2 += d7 * D2D7;
        tmp2 += d8 * D2D8;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        tmp3 += d7 * D3D7;
        tmp3 += d8 * D3D8;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        tmp4 += d7 * D4D7;
        tmp4 += d8 * D4D8;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        tmp5 += d7 * D5D7;
        tmp5 += d8 * D5D8;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        tmp6 += d7 * D6D7;
        tmp6 += d8 * D6D8;
        result += d6 * tmp6;

        var tmp7 = 0.0;
        tmp7 += d0 * D0D7;
        tmp7 += d1 * D1D7;
        tmp7 += d2 * D2D7;
        tmp7 += d3 * D3D7;
        tmp7 += d4 * D4D7;
        tmp7 += d5 * D5D7;
        tmp7 += d6 * D6D7;
        tmp7 += d7 * D7D7;
        tmp7 += d8 * D7D8;
        result += d7 * tmp7;

        var tmp8 = 0.0;
        tmp8 += d0 * D0D8;
        tmp8 += d1 * D1D8;
        tmp8 += d2 * D2D8;
        tmp8 += d3 * D3D8;
        tmp8 += d4 * D4D8;
        tmp8 += d5 * D5D8;
        tmp8 += d6 * D6D8;
        tmp8 += d7 * D7D8;
        tmp8 += d8 * D8D8;
        result += d8 * tmp8;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;
        result += D7 * d7;
        result += D8 * d8;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD9Scalar lhs, DD9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD9Scalar);
	}

	public bool Equals(DD9Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD9Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 9;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 55);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 55)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 9)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 45)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (17 - i) * i / 2 + j
            : (17 - j) * j / 2 + i;

		if (idx >= 45)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar Forward(double constant, double da, double dada, DD9Scalar a)
    {
        var result = new DD9Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;
        var ca7 = dada * a.D7;
        var ca8 = dada * a.D8;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D0D7 = da * a.D0D7 + ca0 * a.D7;
        result.D0D8 = da * a.D0D8 + ca0 * a.D8;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D1D7 = da * a.D1D7 + ca1 * a.D7;
        result.D1D8 = da * a.D1D8 + ca1 * a.D8;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D2D7 = da * a.D2D7 + ca2 * a.D7;
        result.D2D8 = da * a.D2D8 + ca2 * a.D8;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D3D7 = da * a.D3D7 + ca3 * a.D7;
        result.D3D8 = da * a.D3D8 + ca3 * a.D8;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D4D7 = da * a.D4D7 + ca4 * a.D7;
        result.D4D8 = da * a.D4D8 + ca4 * a.D8;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D5D7 = da * a.D5D7 + ca5 * a.D7;
        result.D5D8 = da * a.D5D8 + ca5 * a.D8;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;
        result.D6D7 = da * a.D6D7 + ca6 * a.D7;
        result.D6D8 = da * a.D6D8 + ca6 * a.D8;
        result.D7D7 = da * a.D7D7 + ca7 * a.D7;
        result.D7D8 = da * a.D7D8 + ca7 * a.D8;
        result.D8D8 = da * a.D8D8 + ca8 * a.D8;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD9Scalar a, DD9Scalar b)
    {
        var result = new DD9Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;
        var ca7 = dada * a.D7 + dadb * b.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7;
        var ca8 = dada * a.D8 + dadb * b.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD9Scalar a, DD9Scalar b, DD9Scalar c)
    {
        var result = new DD9Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        result.D8 = da * a.D8 + db * b.D8 + dc * c.D8;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;
        var ca7 = dada * a.D7 + dadb * b.D7 + dadc * c.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7 + dbdc * c.D7;
        var cc7 = dadc * a.D7 + dbdc * b.D7 + dcdc * c.D7;
        var ca8 = dada * a.D8 + dadb * b.D8 + dadc * c.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8 + dbdc * c.D8;
        var cc8 = dadc * a.D8 + dbdc * b.D8 + dcdc * c.D8;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + dc * c.D0D7 + ca0 * a.D7 + cb0 * b.D7 + cc0 * c.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + dc * c.D0D8 + ca0 * a.D8 + cb0 * b.D8 + cc0 * c.D8;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + dc * c.D1D7 + ca1 * a.D7 + cb1 * b.D7 + cc1 * c.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + dc * c.D1D8 + ca1 * a.D8 + cb1 * b.D8 + cc1 * c.D8;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + dc * c.D2D7 + ca2 * a.D7 + cb2 * b.D7 + cc2 * c.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + dc * c.D2D8 + ca2 * a.D8 + cb2 * b.D8 + cc2 * c.D8;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + dc * c.D3D7 + ca3 * a.D7 + cb3 * b.D7 + cc3 * c.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + dc * c.D3D8 + ca3 * a.D8 + cb3 * b.D8 + cc3 * c.D8;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + dc * c.D4D7 + ca4 * a.D7 + cb4 * b.D7 + cc4 * c.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + dc * c.D4D8 + ca4 * a.D8 + cb4 * b.D8 + cc4 * c.D8;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + dc * c.D5D7 + ca5 * a.D7 + cb5 * b.D7 + cc5 * c.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + dc * c.D5D8 + ca5 * a.D8 + cb5 * b.D8 + cc5 * c.D8;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + dc * c.D6D7 + ca6 * a.D7 + cb6 * b.D7 + cc6 * c.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + dc * c.D6D8 + ca6 * a.D8 + cb6 * b.D8 + cc6 * c.D8;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + dc * c.D7D7 + ca7 * a.D7 + cb7 * b.D7 + cc7 * c.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + dc * c.D7D8 + ca7 * a.D8 + cb7 * b.D8 + cc7 * c.D8;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + dc * c.D8D8 + ca8 * a.D8 + cb8 * b.D8 + cc8 * c.D8;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator -(DD9Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator +(DD9Scalar lhs, DD9Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator +(double lhs, DD9Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator +(DD9Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator -(DD9Scalar lhs, DD9Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator -(double lhs, DD9Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator -(DD9Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator *(DD9Scalar lhs, DD9Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator *(double lhs, DD9Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator *(DD9Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator /(DD9Scalar lhs, DD9Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator /(double lhs, DD9Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD9Scalar operator /(DD9Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD10Scalar : IScalar, IEquatable<DD10Scalar>, IComparable<DD10Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D7;
    public double D8;
    public double D9;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D0D7;
    public double D0D8;
    public double D0D9;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D1D7;
    public double D1D8;
    public double D1D9;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D2D7;
    public double D2D8;
    public double D2D9;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D3D7;
    public double D3D8;
    public double D3D9;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D4D7;
    public double D4D8;
    public double D4D9;
    public double D5D5;
    public double D5D6;
    public double D5D7;
    public double D5D8;
    public double D5D9;
    public double D6D6;
    public double D6D7;
    public double D6D8;
    public double D6D9;
    public double D7D7;
    public double D7D8;
    public double D7D9;
    public double D8D8;
    public double D8D9;
    public double D9D9;

    public DD10Scalar()
    {
    }

    public DD10Scalar(double constant)
    {
        Constant = constant;
    }

    public DD10Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d0d7, double d0d8, double d0d9, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d1d7, double d1d8, double d1d9, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d2d7, double d2d8, double d2d9, double d3d3, double d3d4, double d3d5, double d3d6, double d3d7, double d3d8, double d3d9, double d4d4, double d4d5, double d4d6, double d4d7, double d4d8, double d4d9, double d5d5, double d5d6, double d5d7, double d5d8, double d5d9, double d6d6, double d6d7, double d6d8, double d6d9, double d7d7, double d7d8, double d7d9, double d8d8, double d8d9, double d9d9)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D7 = d7;
        D8 = d8;
        D9 = d9;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D0D7 = d0d7;
        D0D8 = d0d8;
        D0D9 = d0d9;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D1D7 = d1d7;
        D1D8 = d1d8;
        D1D9 = d1d9;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D2D7 = d2d7;
        D2D8 = d2d8;
        D2D9 = d2d9;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D3D7 = d3d7;
        D3D8 = d3d8;
        D3D9 = d3d9;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D4D7 = d4d7;
        D4D8 = d4d8;
        D4D9 = d4d9;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D5D7 = d5d7;
        D5D8 = d5d8;
        D5D9 = d5d9;
        D6D6 = d6d6;
        D6D7 = d6d7;
        D6D8 = d6d8;
        D6D9 = d6d9;
        D7D7 = d7d7;
        D7D8 = d7d8;
        D7D9 = d7d9;
        D8D8 = d8d8;
        D8D9 = d8d9;
        D9D9 = d9d9;
    }
    
    public DD10Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D7 = data[8];
        D8 = data[9];
        D9 = data[10];
        D0D0 = data[11];
        D0D1 = data[12];
        D0D2 = data[13];
        D0D3 = data[14];
        D0D4 = data[15];
        D0D5 = data[16];
        D0D6 = data[17];
        D0D7 = data[18];
        D0D8 = data[19];
        D0D9 = data[20];
        D1D1 = data[21];
        D1D2 = data[22];
        D1D3 = data[23];
        D1D4 = data[24];
        D1D5 = data[25];
        D1D6 = data[26];
        D1D7 = data[27];
        D1D8 = data[28];
        D1D9 = data[29];
        D2D2 = data[30];
        D2D3 = data[31];
        D2D4 = data[32];
        D2D5 = data[33];
        D2D6 = data[34];
        D2D7 = data[35];
        D2D8 = data[36];
        D2D9 = data[37];
        D3D3 = data[38];
        D3D4 = data[39];
        D3D5 = data[40];
        D3D6 = data[41];
        D3D7 = data[42];
        D3D8 = data[43];
        D3D9 = data[44];
        D4D4 = data[45];
        D4D5 = data[46];
        D4D6 = data[47];
        D4D7 = data[48];
        D4D8 = data[49];
        D4D9 = data[50];
        D5D5 = data[51];
        D5D6 = data[52];
        D5D7 = data[53];
        D5D8 = data[54];
        D5D9 = data[55];
        D6D6 = data[56];
        D6D7 = data[57];
        D6D8 = data[58];
        D6D9 = data[59];
        D7D7 = data[60];
        D7D8 = data[61];
        D7D9 = data[62];
        D8D8 = data[63];
        D8D9 = data[64];
        D9D9 = data[65];
    }

    public static DD10Scalar Variable0(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD10Scalar Variable1(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD10Scalar Variable2(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD10Scalar Variable3(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD10Scalar Variable4(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD10Scalar Variable5(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD10Scalar Variable6(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static DD10Scalar Variable7(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static DD10Scalar Variable8(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static DD10Scalar Variable9(double constant)
    {
        var result = new DD10Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static (DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar, DD10Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);
        var variable7 = Variable7(constant7);
        var variable8 = Variable8(constant8);
        var variable9 = Variable9(constant9);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6, variable7, variable8, variable9);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        tmp0 += d7 * D0D7;
        tmp0 += d8 * D0D8;
        tmp0 += d9 * D0D9;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        tmp1 += d7 * D1D7;
        tmp1 += d8 * D1D8;
        tmp1 += d9 * D1D9;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        tmp2 += d7 * D2D7;
        tmp2 += d8 * D2D8;
        tmp2 += d9 * D2D9;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        tmp3 += d7 * D3D7;
        tmp3 += d8 * D3D8;
        tmp3 += d9 * D3D9;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        tmp4 += d7 * D4D7;
        tmp4 += d8 * D4D8;
        tmp4 += d9 * D4D9;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        tmp5 += d7 * D5D7;
        tmp5 += d8 * D5D8;
        tmp5 += d9 * D5D9;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        tmp6 += d7 * D6D7;
        tmp6 += d8 * D6D8;
        tmp6 += d9 * D6D9;
        result += d6 * tmp6;

        var tmp7 = 0.0;
        tmp7 += d0 * D0D7;
        tmp7 += d1 * D1D7;
        tmp7 += d2 * D2D7;
        tmp7 += d3 * D3D7;
        tmp7 += d4 * D4D7;
        tmp7 += d5 * D5D7;
        tmp7 += d6 * D6D7;
        tmp7 += d7 * D7D7;
        tmp7 += d8 * D7D8;
        tmp7 += d9 * D7D9;
        result += d7 * tmp7;

        var tmp8 = 0.0;
        tmp8 += d0 * D0D8;
        tmp8 += d1 * D1D8;
        tmp8 += d2 * D2D8;
        tmp8 += d3 * D3D8;
        tmp8 += d4 * D4D8;
        tmp8 += d5 * D5D8;
        tmp8 += d6 * D6D8;
        tmp8 += d7 * D7D8;
        tmp8 += d8 * D8D8;
        tmp8 += d9 * D8D9;
        result += d8 * tmp8;

        var tmp9 = 0.0;
        tmp9 += d0 * D0D9;
        tmp9 += d1 * D1D9;
        tmp9 += d2 * D2D9;
        tmp9 += d3 * D3D9;
        tmp9 += d4 * D4D9;
        tmp9 += d5 * D5D9;
        tmp9 += d6 * D6D9;
        tmp9 += d7 * D7D9;
        tmp9 += d8 * D8D9;
        tmp9 += d9 * D9D9;
        result += d9 * tmp9;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;
        result += D7 * d7;
        result += D8 * d8;
        result += D9 * d9;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD10Scalar lhs, DD10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD10Scalar);
	}

	public bool Equals(DD10Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD10Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 10;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 66);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 66)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 10)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 55)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (19 - i) * i / 2 + j
            : (19 - j) * j / 2 + i;

		if (idx >= 55)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar Forward(double constant, double da, double dada, DD10Scalar a)
    {
        var result = new DD10Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;
        var ca7 = dada * a.D7;
        var ca8 = dada * a.D8;
        var ca9 = dada * a.D9;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D0D7 = da * a.D0D7 + ca0 * a.D7;
        result.D0D8 = da * a.D0D8 + ca0 * a.D8;
        result.D0D9 = da * a.D0D9 + ca0 * a.D9;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D1D7 = da * a.D1D7 + ca1 * a.D7;
        result.D1D8 = da * a.D1D8 + ca1 * a.D8;
        result.D1D9 = da * a.D1D9 + ca1 * a.D9;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D2D7 = da * a.D2D7 + ca2 * a.D7;
        result.D2D8 = da * a.D2D8 + ca2 * a.D8;
        result.D2D9 = da * a.D2D9 + ca2 * a.D9;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D3D7 = da * a.D3D7 + ca3 * a.D7;
        result.D3D8 = da * a.D3D8 + ca3 * a.D8;
        result.D3D9 = da * a.D3D9 + ca3 * a.D9;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D4D7 = da * a.D4D7 + ca4 * a.D7;
        result.D4D8 = da * a.D4D8 + ca4 * a.D8;
        result.D4D9 = da * a.D4D9 + ca4 * a.D9;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D5D7 = da * a.D5D7 + ca5 * a.D7;
        result.D5D8 = da * a.D5D8 + ca5 * a.D8;
        result.D5D9 = da * a.D5D9 + ca5 * a.D9;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;
        result.D6D7 = da * a.D6D7 + ca6 * a.D7;
        result.D6D8 = da * a.D6D8 + ca6 * a.D8;
        result.D6D9 = da * a.D6D9 + ca6 * a.D9;
        result.D7D7 = da * a.D7D7 + ca7 * a.D7;
        result.D7D8 = da * a.D7D8 + ca7 * a.D8;
        result.D7D9 = da * a.D7D9 + ca7 * a.D9;
        result.D8D8 = da * a.D8D8 + ca8 * a.D8;
        result.D8D9 = da * a.D8D9 + ca8 * a.D9;
        result.D9D9 = da * a.D9D9 + ca9 * a.D9;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD10Scalar a, DD10Scalar b)
    {
        var result = new DD10Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;
        var ca7 = dada * a.D7 + dadb * b.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7;
        var ca8 = dada * a.D8 + dadb * b.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8;
        var ca9 = dada * a.D9 + dadb * b.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD10Scalar a, DD10Scalar b, DD10Scalar c)
    {
        var result = new DD10Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        result.D8 = da * a.D8 + db * b.D8 + dc * c.D8;
        result.D9 = da * a.D9 + db * b.D9 + dc * c.D9;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;
        var ca7 = dada * a.D7 + dadb * b.D7 + dadc * c.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7 + dbdc * c.D7;
        var cc7 = dadc * a.D7 + dbdc * b.D7 + dcdc * c.D7;
        var ca8 = dada * a.D8 + dadb * b.D8 + dadc * c.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8 + dbdc * c.D8;
        var cc8 = dadc * a.D8 + dbdc * b.D8 + dcdc * c.D8;
        var ca9 = dada * a.D9 + dadb * b.D9 + dadc * c.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9 + dbdc * c.D9;
        var cc9 = dadc * a.D9 + dbdc * b.D9 + dcdc * c.D9;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + dc * c.D0D7 + ca0 * a.D7 + cb0 * b.D7 + cc0 * c.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + dc * c.D0D8 + ca0 * a.D8 + cb0 * b.D8 + cc0 * c.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + dc * c.D0D9 + ca0 * a.D9 + cb0 * b.D9 + cc0 * c.D9;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + dc * c.D1D7 + ca1 * a.D7 + cb1 * b.D7 + cc1 * c.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + dc * c.D1D8 + ca1 * a.D8 + cb1 * b.D8 + cc1 * c.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + dc * c.D1D9 + ca1 * a.D9 + cb1 * b.D9 + cc1 * c.D9;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + dc * c.D2D7 + ca2 * a.D7 + cb2 * b.D7 + cc2 * c.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + dc * c.D2D8 + ca2 * a.D8 + cb2 * b.D8 + cc2 * c.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + dc * c.D2D9 + ca2 * a.D9 + cb2 * b.D9 + cc2 * c.D9;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + dc * c.D3D7 + ca3 * a.D7 + cb3 * b.D7 + cc3 * c.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + dc * c.D3D8 + ca3 * a.D8 + cb3 * b.D8 + cc3 * c.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + dc * c.D3D9 + ca3 * a.D9 + cb3 * b.D9 + cc3 * c.D9;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + dc * c.D4D7 + ca4 * a.D7 + cb4 * b.D7 + cc4 * c.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + dc * c.D4D8 + ca4 * a.D8 + cb4 * b.D8 + cc4 * c.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + dc * c.D4D9 + ca4 * a.D9 + cb4 * b.D9 + cc4 * c.D9;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + dc * c.D5D7 + ca5 * a.D7 + cb5 * b.D7 + cc5 * c.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + dc * c.D5D8 + ca5 * a.D8 + cb5 * b.D8 + cc5 * c.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + dc * c.D5D9 + ca5 * a.D9 + cb5 * b.D9 + cc5 * c.D9;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + dc * c.D6D7 + ca6 * a.D7 + cb6 * b.D7 + cc6 * c.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + dc * c.D6D8 + ca6 * a.D8 + cb6 * b.D8 + cc6 * c.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + dc * c.D6D9 + ca6 * a.D9 + cb6 * b.D9 + cc6 * c.D9;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + dc * c.D7D7 + ca7 * a.D7 + cb7 * b.D7 + cc7 * c.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + dc * c.D7D8 + ca7 * a.D8 + cb7 * b.D8 + cc7 * c.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + dc * c.D7D9 + ca7 * a.D9 + cb7 * b.D9 + cc7 * c.D9;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + dc * c.D8D8 + ca8 * a.D8 + cb8 * b.D8 + cc8 * c.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + dc * c.D8D9 + ca8 * a.D9 + cb8 * b.D9 + cc8 * c.D9;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + dc * c.D9D9 + ca9 * a.D9 + cb9 * b.D9 + cc9 * c.D9;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator -(DD10Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator +(DD10Scalar lhs, DD10Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator +(double lhs, DD10Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator +(DD10Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator -(DD10Scalar lhs, DD10Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator -(double lhs, DD10Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator -(DD10Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator *(DD10Scalar lhs, DD10Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator *(double lhs, DD10Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator *(DD10Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator /(DD10Scalar lhs, DD10Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator /(double lhs, DD10Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD10Scalar operator /(DD10Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD11Scalar : IScalar, IEquatable<DD11Scalar>, IComparable<DD11Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D7;
    public double D8;
    public double D9;
    public double D10;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D0D7;
    public double D0D8;
    public double D0D9;
    public double D0D10;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D1D7;
    public double D1D8;
    public double D1D9;
    public double D1D10;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D2D7;
    public double D2D8;
    public double D2D9;
    public double D2D10;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D3D7;
    public double D3D8;
    public double D3D9;
    public double D3D10;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D4D7;
    public double D4D8;
    public double D4D9;
    public double D4D10;
    public double D5D5;
    public double D5D6;
    public double D5D7;
    public double D5D8;
    public double D5D9;
    public double D5D10;
    public double D6D6;
    public double D6D7;
    public double D6D8;
    public double D6D9;
    public double D6D10;
    public double D7D7;
    public double D7D8;
    public double D7D9;
    public double D7D10;
    public double D8D8;
    public double D8D9;
    public double D8D10;
    public double D9D9;
    public double D9D10;
    public double D10D10;

    public DD11Scalar()
    {
    }

    public DD11Scalar(double constant)
    {
        Constant = constant;
    }

    public DD11Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d0d7, double d0d8, double d0d9, double d0d10, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d1d7, double d1d8, double d1d9, double d1d10, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d2d7, double d2d8, double d2d9, double d2d10, double d3d3, double d3d4, double d3d5, double d3d6, double d3d7, double d3d8, double d3d9, double d3d10, double d4d4, double d4d5, double d4d6, double d4d7, double d4d8, double d4d9, double d4d10, double d5d5, double d5d6, double d5d7, double d5d8, double d5d9, double d5d10, double d6d6, double d6d7, double d6d8, double d6d9, double d6d10, double d7d7, double d7d8, double d7d9, double d7d10, double d8d8, double d8d9, double d8d10, double d9d9, double d9d10, double d10d10)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D7 = d7;
        D8 = d8;
        D9 = d9;
        D10 = d10;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D0D7 = d0d7;
        D0D8 = d0d8;
        D0D9 = d0d9;
        D0D10 = d0d10;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D1D7 = d1d7;
        D1D8 = d1d8;
        D1D9 = d1d9;
        D1D10 = d1d10;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D2D7 = d2d7;
        D2D8 = d2d8;
        D2D9 = d2d9;
        D2D10 = d2d10;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D3D7 = d3d7;
        D3D8 = d3d8;
        D3D9 = d3d9;
        D3D10 = d3d10;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D4D7 = d4d7;
        D4D8 = d4d8;
        D4D9 = d4d9;
        D4D10 = d4d10;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D5D7 = d5d7;
        D5D8 = d5d8;
        D5D9 = d5d9;
        D5D10 = d5d10;
        D6D6 = d6d6;
        D6D7 = d6d7;
        D6D8 = d6d8;
        D6D9 = d6d9;
        D6D10 = d6d10;
        D7D7 = d7d7;
        D7D8 = d7d8;
        D7D9 = d7d9;
        D7D10 = d7d10;
        D8D8 = d8d8;
        D8D9 = d8d9;
        D8D10 = d8d10;
        D9D9 = d9d9;
        D9D10 = d9d10;
        D10D10 = d10d10;
    }
    
    public DD11Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D7 = data[8];
        D8 = data[9];
        D9 = data[10];
        D10 = data[11];
        D0D0 = data[12];
        D0D1 = data[13];
        D0D2 = data[14];
        D0D3 = data[15];
        D0D4 = data[16];
        D0D5 = data[17];
        D0D6 = data[18];
        D0D7 = data[19];
        D0D8 = data[20];
        D0D9 = data[21];
        D0D10 = data[22];
        D1D1 = data[23];
        D1D2 = data[24];
        D1D3 = data[25];
        D1D4 = data[26];
        D1D5 = data[27];
        D1D6 = data[28];
        D1D7 = data[29];
        D1D8 = data[30];
        D1D9 = data[31];
        D1D10 = data[32];
        D2D2 = data[33];
        D2D3 = data[34];
        D2D4 = data[35];
        D2D5 = data[36];
        D2D6 = data[37];
        D2D7 = data[38];
        D2D8 = data[39];
        D2D9 = data[40];
        D2D10 = data[41];
        D3D3 = data[42];
        D3D4 = data[43];
        D3D5 = data[44];
        D3D6 = data[45];
        D3D7 = data[46];
        D3D8 = data[47];
        D3D9 = data[48];
        D3D10 = data[49];
        D4D4 = data[50];
        D4D5 = data[51];
        D4D6 = data[52];
        D4D7 = data[53];
        D4D8 = data[54];
        D4D9 = data[55];
        D4D10 = data[56];
        D5D5 = data[57];
        D5D6 = data[58];
        D5D7 = data[59];
        D5D8 = data[60];
        D5D9 = data[61];
        D5D10 = data[62];
        D6D6 = data[63];
        D6D7 = data[64];
        D6D8 = data[65];
        D6D9 = data[66];
        D6D10 = data[67];
        D7D7 = data[68];
        D7D8 = data[69];
        D7D9 = data[70];
        D7D10 = data[71];
        D8D8 = data[72];
        D8D9 = data[73];
        D8D10 = data[74];
        D9D9 = data[75];
        D9D10 = data[76];
        D10D10 = data[77];
    }

    public static DD11Scalar Variable0(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD11Scalar Variable1(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD11Scalar Variable2(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD11Scalar Variable3(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD11Scalar Variable4(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD11Scalar Variable5(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD11Scalar Variable6(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static DD11Scalar Variable7(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static DD11Scalar Variable8(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static DD11Scalar Variable9(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static DD11Scalar Variable10(double constant)
    {
        var result = new DD11Scalar();
        result.Constant = constant;
        result.D10 = 1;
        return result;
    }

    public static (DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar, DD11Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9, double constant10)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);
        var variable7 = Variable7(constant7);
        var variable8 = Variable8(constant8);
        var variable9 = Variable9(constant9);
        var variable10 = Variable10(constant10);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6, variable7, variable8, variable9, variable10);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        tmp0 += d7 * D0D7;
        tmp0 += d8 * D0D8;
        tmp0 += d9 * D0D9;
        tmp0 += d10 * D0D10;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        tmp1 += d7 * D1D7;
        tmp1 += d8 * D1D8;
        tmp1 += d9 * D1D9;
        tmp1 += d10 * D1D10;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        tmp2 += d7 * D2D7;
        tmp2 += d8 * D2D8;
        tmp2 += d9 * D2D9;
        tmp2 += d10 * D2D10;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        tmp3 += d7 * D3D7;
        tmp3 += d8 * D3D8;
        tmp3 += d9 * D3D9;
        tmp3 += d10 * D3D10;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        tmp4 += d7 * D4D7;
        tmp4 += d8 * D4D8;
        tmp4 += d9 * D4D9;
        tmp4 += d10 * D4D10;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        tmp5 += d7 * D5D7;
        tmp5 += d8 * D5D8;
        tmp5 += d9 * D5D9;
        tmp5 += d10 * D5D10;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        tmp6 += d7 * D6D7;
        tmp6 += d8 * D6D8;
        tmp6 += d9 * D6D9;
        tmp6 += d10 * D6D10;
        result += d6 * tmp6;

        var tmp7 = 0.0;
        tmp7 += d0 * D0D7;
        tmp7 += d1 * D1D7;
        tmp7 += d2 * D2D7;
        tmp7 += d3 * D3D7;
        tmp7 += d4 * D4D7;
        tmp7 += d5 * D5D7;
        tmp7 += d6 * D6D7;
        tmp7 += d7 * D7D7;
        tmp7 += d8 * D7D8;
        tmp7 += d9 * D7D9;
        tmp7 += d10 * D7D10;
        result += d7 * tmp7;

        var tmp8 = 0.0;
        tmp8 += d0 * D0D8;
        tmp8 += d1 * D1D8;
        tmp8 += d2 * D2D8;
        tmp8 += d3 * D3D8;
        tmp8 += d4 * D4D8;
        tmp8 += d5 * D5D8;
        tmp8 += d6 * D6D8;
        tmp8 += d7 * D7D8;
        tmp8 += d8 * D8D8;
        tmp8 += d9 * D8D9;
        tmp8 += d10 * D8D10;
        result += d8 * tmp8;

        var tmp9 = 0.0;
        tmp9 += d0 * D0D9;
        tmp9 += d1 * D1D9;
        tmp9 += d2 * D2D9;
        tmp9 += d3 * D3D9;
        tmp9 += d4 * D4D9;
        tmp9 += d5 * D5D9;
        tmp9 += d6 * D6D9;
        tmp9 += d7 * D7D9;
        tmp9 += d8 * D8D9;
        tmp9 += d9 * D9D9;
        tmp9 += d10 * D9D10;
        result += d9 * tmp9;

        var tmp10 = 0.0;
        tmp10 += d0 * D0D10;
        tmp10 += d1 * D1D10;
        tmp10 += d2 * D2D10;
        tmp10 += d3 * D3D10;
        tmp10 += d4 * D4D10;
        tmp10 += d5 * D5D10;
        tmp10 += d6 * D6D10;
        tmp10 += d7 * D7D10;
        tmp10 += d8 * D8D10;
        tmp10 += d9 * D9D10;
        tmp10 += d10 * D10D10;
        result += d10 * tmp10;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;
        result += D7 * d7;
        result += D8 * d8;
        result += D9 * d9;
        result += D10 * d10;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD11Scalar lhs, DD11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD11Scalar);
	}

	public bool Equals(DD11Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD11Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 11;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 78);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 78)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 11)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 66)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (21 - i) * i / 2 + j
            : (21 - j) * j / 2 + i;

		if (idx >= 66)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar Forward(double constant, double da, double dada, DD11Scalar a)
    {
        var result = new DD11Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;
        var ca7 = dada * a.D7;
        var ca8 = dada * a.D8;
        var ca9 = dada * a.D9;
        var ca10 = dada * a.D10;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D0D7 = da * a.D0D7 + ca0 * a.D7;
        result.D0D8 = da * a.D0D8 + ca0 * a.D8;
        result.D0D9 = da * a.D0D9 + ca0 * a.D9;
        result.D0D10 = da * a.D0D10 + ca0 * a.D10;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D1D7 = da * a.D1D7 + ca1 * a.D7;
        result.D1D8 = da * a.D1D8 + ca1 * a.D8;
        result.D1D9 = da * a.D1D9 + ca1 * a.D9;
        result.D1D10 = da * a.D1D10 + ca1 * a.D10;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D2D7 = da * a.D2D7 + ca2 * a.D7;
        result.D2D8 = da * a.D2D8 + ca2 * a.D8;
        result.D2D9 = da * a.D2D9 + ca2 * a.D9;
        result.D2D10 = da * a.D2D10 + ca2 * a.D10;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D3D7 = da * a.D3D7 + ca3 * a.D7;
        result.D3D8 = da * a.D3D8 + ca3 * a.D8;
        result.D3D9 = da * a.D3D9 + ca3 * a.D9;
        result.D3D10 = da * a.D3D10 + ca3 * a.D10;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D4D7 = da * a.D4D7 + ca4 * a.D7;
        result.D4D8 = da * a.D4D8 + ca4 * a.D8;
        result.D4D9 = da * a.D4D9 + ca4 * a.D9;
        result.D4D10 = da * a.D4D10 + ca4 * a.D10;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D5D7 = da * a.D5D7 + ca5 * a.D7;
        result.D5D8 = da * a.D5D8 + ca5 * a.D8;
        result.D5D9 = da * a.D5D9 + ca5 * a.D9;
        result.D5D10 = da * a.D5D10 + ca5 * a.D10;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;
        result.D6D7 = da * a.D6D7 + ca6 * a.D7;
        result.D6D8 = da * a.D6D8 + ca6 * a.D8;
        result.D6D9 = da * a.D6D9 + ca6 * a.D9;
        result.D6D10 = da * a.D6D10 + ca6 * a.D10;
        result.D7D7 = da * a.D7D7 + ca7 * a.D7;
        result.D7D8 = da * a.D7D8 + ca7 * a.D8;
        result.D7D9 = da * a.D7D9 + ca7 * a.D9;
        result.D7D10 = da * a.D7D10 + ca7 * a.D10;
        result.D8D8 = da * a.D8D8 + ca8 * a.D8;
        result.D8D9 = da * a.D8D9 + ca8 * a.D9;
        result.D8D10 = da * a.D8D10 + ca8 * a.D10;
        result.D9D9 = da * a.D9D9 + ca9 * a.D9;
        result.D9D10 = da * a.D9D10 + ca9 * a.D10;
        result.D10D10 = da * a.D10D10 + ca10 * a.D10;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD11Scalar a, DD11Scalar b)
    {
        var result = new DD11Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;
        var ca7 = dada * a.D7 + dadb * b.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7;
        var ca8 = dada * a.D8 + dadb * b.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8;
        var ca9 = dada * a.D9 + dadb * b.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9;
        var ca10 = dada * a.D10 + dadb * b.D10;
        var cb10 = dadb * a.D10 + dbdb * b.D10;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + ca0 * a.D10 + cb0 * b.D10;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + ca1 * a.D10 + cb1 * b.D10;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + ca2 * a.D10 + cb2 * b.D10;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + ca3 * a.D10 + cb3 * b.D10;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + ca4 * a.D10 + cb4 * b.D10;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + ca5 * a.D10 + cb5 * b.D10;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + ca6 * a.D10 + cb6 * b.D10;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + ca7 * a.D10 + cb7 * b.D10;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + ca8 * a.D10 + cb8 * b.D10;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + ca9 * a.D10 + cb9 * b.D10;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + ca10 * a.D10 + cb10 * b.D10;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD11Scalar a, DD11Scalar b, DD11Scalar c)
    {
        var result = new DD11Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        result.D8 = da * a.D8 + db * b.D8 + dc * c.D8;
        result.D9 = da * a.D9 + db * b.D9 + dc * c.D9;
        result.D10 = da * a.D10 + db * b.D10 + dc * c.D10;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;
        var ca7 = dada * a.D7 + dadb * b.D7 + dadc * c.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7 + dbdc * c.D7;
        var cc7 = dadc * a.D7 + dbdc * b.D7 + dcdc * c.D7;
        var ca8 = dada * a.D8 + dadb * b.D8 + dadc * c.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8 + dbdc * c.D8;
        var cc8 = dadc * a.D8 + dbdc * b.D8 + dcdc * c.D8;
        var ca9 = dada * a.D9 + dadb * b.D9 + dadc * c.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9 + dbdc * c.D9;
        var cc9 = dadc * a.D9 + dbdc * b.D9 + dcdc * c.D9;
        var ca10 = dada * a.D10 + dadb * b.D10 + dadc * c.D10;
        var cb10 = dadb * a.D10 + dbdb * b.D10 + dbdc * c.D10;
        var cc10 = dadc * a.D10 + dbdc * b.D10 + dcdc * c.D10;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + dc * c.D0D7 + ca0 * a.D7 + cb0 * b.D7 + cc0 * c.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + dc * c.D0D8 + ca0 * a.D8 + cb0 * b.D8 + cc0 * c.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + dc * c.D0D9 + ca0 * a.D9 + cb0 * b.D9 + cc0 * c.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + dc * c.D0D10 + ca0 * a.D10 + cb0 * b.D10 + cc0 * c.D10;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + dc * c.D1D7 + ca1 * a.D7 + cb1 * b.D7 + cc1 * c.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + dc * c.D1D8 + ca1 * a.D8 + cb1 * b.D8 + cc1 * c.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + dc * c.D1D9 + ca1 * a.D9 + cb1 * b.D9 + cc1 * c.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + dc * c.D1D10 + ca1 * a.D10 + cb1 * b.D10 + cc1 * c.D10;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + dc * c.D2D7 + ca2 * a.D7 + cb2 * b.D7 + cc2 * c.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + dc * c.D2D8 + ca2 * a.D8 + cb2 * b.D8 + cc2 * c.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + dc * c.D2D9 + ca2 * a.D9 + cb2 * b.D9 + cc2 * c.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + dc * c.D2D10 + ca2 * a.D10 + cb2 * b.D10 + cc2 * c.D10;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + dc * c.D3D7 + ca3 * a.D7 + cb3 * b.D7 + cc3 * c.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + dc * c.D3D8 + ca3 * a.D8 + cb3 * b.D8 + cc3 * c.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + dc * c.D3D9 + ca3 * a.D9 + cb3 * b.D9 + cc3 * c.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + dc * c.D3D10 + ca3 * a.D10 + cb3 * b.D10 + cc3 * c.D10;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + dc * c.D4D7 + ca4 * a.D7 + cb4 * b.D7 + cc4 * c.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + dc * c.D4D8 + ca4 * a.D8 + cb4 * b.D8 + cc4 * c.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + dc * c.D4D9 + ca4 * a.D9 + cb4 * b.D9 + cc4 * c.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + dc * c.D4D10 + ca4 * a.D10 + cb4 * b.D10 + cc4 * c.D10;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + dc * c.D5D7 + ca5 * a.D7 + cb5 * b.D7 + cc5 * c.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + dc * c.D5D8 + ca5 * a.D8 + cb5 * b.D8 + cc5 * c.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + dc * c.D5D9 + ca5 * a.D9 + cb5 * b.D9 + cc5 * c.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + dc * c.D5D10 + ca5 * a.D10 + cb5 * b.D10 + cc5 * c.D10;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + dc * c.D6D7 + ca6 * a.D7 + cb6 * b.D7 + cc6 * c.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + dc * c.D6D8 + ca6 * a.D8 + cb6 * b.D8 + cc6 * c.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + dc * c.D6D9 + ca6 * a.D9 + cb6 * b.D9 + cc6 * c.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + dc * c.D6D10 + ca6 * a.D10 + cb6 * b.D10 + cc6 * c.D10;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + dc * c.D7D7 + ca7 * a.D7 + cb7 * b.D7 + cc7 * c.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + dc * c.D7D8 + ca7 * a.D8 + cb7 * b.D8 + cc7 * c.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + dc * c.D7D9 + ca7 * a.D9 + cb7 * b.D9 + cc7 * c.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + dc * c.D7D10 + ca7 * a.D10 + cb7 * b.D10 + cc7 * c.D10;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + dc * c.D8D8 + ca8 * a.D8 + cb8 * b.D8 + cc8 * c.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + dc * c.D8D9 + ca8 * a.D9 + cb8 * b.D9 + cc8 * c.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + dc * c.D8D10 + ca8 * a.D10 + cb8 * b.D10 + cc8 * c.D10;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + dc * c.D9D9 + ca9 * a.D9 + cb9 * b.D9 + cc9 * c.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + dc * c.D9D10 + ca9 * a.D10 + cb9 * b.D10 + cc9 * c.D10;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + dc * c.D10D10 + ca10 * a.D10 + cb10 * b.D10 + cc10 * c.D10;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator -(DD11Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator +(DD11Scalar lhs, DD11Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator +(double lhs, DD11Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator +(DD11Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator -(DD11Scalar lhs, DD11Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator -(double lhs, DD11Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator -(DD11Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator *(DD11Scalar lhs, DD11Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator *(double lhs, DD11Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator *(DD11Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator /(DD11Scalar lhs, DD11Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator /(double lhs, DD11Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD11Scalar operator /(DD11Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class DD12Scalar : IScalar, IEquatable<DD12Scalar>, IComparable<DD12Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;
    public double D7;
    public double D8;
    public double D9;
    public double D10;
    public double D11;
    public double D0D0;
    public double D0D1;
    public double D0D2;
    public double D0D3;
    public double D0D4;
    public double D0D5;
    public double D0D6;
    public double D0D7;
    public double D0D8;
    public double D0D9;
    public double D0D10;
    public double D0D11;
    public double D1D1;
    public double D1D2;
    public double D1D3;
    public double D1D4;
    public double D1D5;
    public double D1D6;
    public double D1D7;
    public double D1D8;
    public double D1D9;
    public double D1D10;
    public double D1D11;
    public double D2D2;
    public double D2D3;
    public double D2D4;
    public double D2D5;
    public double D2D6;
    public double D2D7;
    public double D2D8;
    public double D2D9;
    public double D2D10;
    public double D2D11;
    public double D3D3;
    public double D3D4;
    public double D3D5;
    public double D3D6;
    public double D3D7;
    public double D3D8;
    public double D3D9;
    public double D3D10;
    public double D3D11;
    public double D4D4;
    public double D4D5;
    public double D4D6;
    public double D4D7;
    public double D4D8;
    public double D4D9;
    public double D4D10;
    public double D4D11;
    public double D5D5;
    public double D5D6;
    public double D5D7;
    public double D5D8;
    public double D5D9;
    public double D5D10;
    public double D5D11;
    public double D6D6;
    public double D6D7;
    public double D6D8;
    public double D6D9;
    public double D6D10;
    public double D6D11;
    public double D7D7;
    public double D7D8;
    public double D7D9;
    public double D7D10;
    public double D7D11;
    public double D8D8;
    public double D8D9;
    public double D8D10;
    public double D8D11;
    public double D9D9;
    public double D9D10;
    public double D9D11;
    public double D10D10;
    public double D10D11;
    public double D11D11;

    public DD12Scalar()
    {
    }

    public DD12Scalar(double constant)
    {
        Constant = constant;
    }

    public DD12Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10, double d11, double d0d0, double d0d1, double d0d2, double d0d3, double d0d4, double d0d5, double d0d6, double d0d7, double d0d8, double d0d9, double d0d10, double d0d11, double d1d1, double d1d2, double d1d3, double d1d4, double d1d5, double d1d6, double d1d7, double d1d8, double d1d9, double d1d10, double d1d11, double d2d2, double d2d3, double d2d4, double d2d5, double d2d6, double d2d7, double d2d8, double d2d9, double d2d10, double d2d11, double d3d3, double d3d4, double d3d5, double d3d6, double d3d7, double d3d8, double d3d9, double d3d10, double d3d11, double d4d4, double d4d5, double d4d6, double d4d7, double d4d8, double d4d9, double d4d10, double d4d11, double d5d5, double d5d6, double d5d7, double d5d8, double d5d9, double d5d10, double d5d11, double d6d6, double d6d7, double d6d8, double d6d9, double d6d10, double d6d11, double d7d7, double d7d8, double d7d9, double d7d10, double d7d11, double d8d8, double d8d9, double d8d10, double d8d11, double d9d9, double d9d10, double d9d11, double d10d10, double d10d11, double d11d11)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
        D7 = d7;
        D8 = d8;
        D9 = d9;
        D10 = d10;
        D11 = d11;
        D0D0 = d0d0;
        D0D1 = d0d1;
        D0D2 = d0d2;
        D0D3 = d0d3;
        D0D4 = d0d4;
        D0D5 = d0d5;
        D0D6 = d0d6;
        D0D7 = d0d7;
        D0D8 = d0d8;
        D0D9 = d0d9;
        D0D10 = d0d10;
        D0D11 = d0d11;
        D1D1 = d1d1;
        D1D2 = d1d2;
        D1D3 = d1d3;
        D1D4 = d1d4;
        D1D5 = d1d5;
        D1D6 = d1d6;
        D1D7 = d1d7;
        D1D8 = d1d8;
        D1D9 = d1d9;
        D1D10 = d1d10;
        D1D11 = d1d11;
        D2D2 = d2d2;
        D2D3 = d2d3;
        D2D4 = d2d4;
        D2D5 = d2d5;
        D2D6 = d2d6;
        D2D7 = d2d7;
        D2D8 = d2d8;
        D2D9 = d2d9;
        D2D10 = d2d10;
        D2D11 = d2d11;
        D3D3 = d3d3;
        D3D4 = d3d4;
        D3D5 = d3d5;
        D3D6 = d3d6;
        D3D7 = d3d7;
        D3D8 = d3d8;
        D3D9 = d3d9;
        D3D10 = d3d10;
        D3D11 = d3d11;
        D4D4 = d4d4;
        D4D5 = d4d5;
        D4D6 = d4d6;
        D4D7 = d4d7;
        D4D8 = d4d8;
        D4D9 = d4d9;
        D4D10 = d4d10;
        D4D11 = d4d11;
        D5D5 = d5d5;
        D5D6 = d5d6;
        D5D7 = d5d7;
        D5D8 = d5d8;
        D5D9 = d5d9;
        D5D10 = d5d10;
        D5D11 = d5d11;
        D6D6 = d6d6;
        D6D7 = d6d7;
        D6D8 = d6d8;
        D6D9 = d6d9;
        D6D10 = d6d10;
        D6D11 = d6d11;
        D7D7 = d7d7;
        D7D8 = d7d8;
        D7D9 = d7d9;
        D7D10 = d7d10;
        D7D11 = d7d11;
        D8D8 = d8d8;
        D8D9 = d8d9;
        D8D10 = d8d10;
        D8D11 = d8d11;
        D9D9 = d9d9;
        D9D10 = d9d10;
        D9D11 = d9d11;
        D10D10 = d10d10;
        D10D11 = d10d11;
        D11D11 = d11d11;
    }
    
    public DD12Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
        D7 = data[8];
        D8 = data[9];
        D9 = data[10];
        D10 = data[11];
        D11 = data[12];
        D0D0 = data[13];
        D0D1 = data[14];
        D0D2 = data[15];
        D0D3 = data[16];
        D0D4 = data[17];
        D0D5 = data[18];
        D0D6 = data[19];
        D0D7 = data[20];
        D0D8 = data[21];
        D0D9 = data[22];
        D0D10 = data[23];
        D0D11 = data[24];
        D1D1 = data[25];
        D1D2 = data[26];
        D1D3 = data[27];
        D1D4 = data[28];
        D1D5 = data[29];
        D1D6 = data[30];
        D1D7 = data[31];
        D1D8 = data[32];
        D1D9 = data[33];
        D1D10 = data[34];
        D1D11 = data[35];
        D2D2 = data[36];
        D2D3 = data[37];
        D2D4 = data[38];
        D2D5 = data[39];
        D2D6 = data[40];
        D2D7 = data[41];
        D2D8 = data[42];
        D2D9 = data[43];
        D2D10 = data[44];
        D2D11 = data[45];
        D3D3 = data[46];
        D3D4 = data[47];
        D3D5 = data[48];
        D3D6 = data[49];
        D3D7 = data[50];
        D3D8 = data[51];
        D3D9 = data[52];
        D3D10 = data[53];
        D3D11 = data[54];
        D4D4 = data[55];
        D4D5 = data[56];
        D4D6 = data[57];
        D4D7 = data[58];
        D4D8 = data[59];
        D4D9 = data[60];
        D4D10 = data[61];
        D4D11 = data[62];
        D5D5 = data[63];
        D5D6 = data[64];
        D5D7 = data[65];
        D5D8 = data[66];
        D5D9 = data[67];
        D5D10 = data[68];
        D5D11 = data[69];
        D6D6 = data[70];
        D6D7 = data[71];
        D6D8 = data[72];
        D6D9 = data[73];
        D6D10 = data[74];
        D6D11 = data[75];
        D7D7 = data[76];
        D7D8 = data[77];
        D7D9 = data[78];
        D7D10 = data[79];
        D7D11 = data[80];
        D8D8 = data[81];
        D8D9 = data[82];
        D8D10 = data[83];
        D8D11 = data[84];
        D9D9 = data[85];
        D9D10 = data[86];
        D9D11 = data[87];
        D10D10 = data[88];
        D10D11 = data[89];
        D11D11 = data[90];
    }

    public static DD12Scalar Variable0(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static DD12Scalar Variable1(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static DD12Scalar Variable2(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static DD12Scalar Variable3(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static DD12Scalar Variable4(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static DD12Scalar Variable5(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static DD12Scalar Variable6(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static DD12Scalar Variable7(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static DD12Scalar Variable8(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static DD12Scalar Variable9(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static DD12Scalar Variable10(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D10 = 1;
        return result;
    }

    public static DD12Scalar Variable11(double constant)
    {
        var result = new DD12Scalar();
        result.Constant = constant;
        result.D11 = 1;
        return result;
    }

    public static (DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar, DD12Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9, double constant10, double constant11)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);
        var variable6 = Variable6(constant6);
        var variable7 = Variable7(constant7);
        var variable8 = Variable8(constant8);
        var variable9 = Variable9(constant9);
        var variable10 = Variable10(constant10);
        var variable11 = Variable11(constant11);

        return (variable0, variable1, variable2, variable3, variable4, variable5, variable6, variable7, variable8, variable9, variable10, variable11);
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10, double d11)
    {
        var result = 0.0;
        
        var tmp0 = 0.0;
        tmp0 += d0 * D0D0;
        tmp0 += d1 * D0D1;
        tmp0 += d2 * D0D2;
        tmp0 += d3 * D0D3;
        tmp0 += d4 * D0D4;
        tmp0 += d5 * D0D5;
        tmp0 += d6 * D0D6;
        tmp0 += d7 * D0D7;
        tmp0 += d8 * D0D8;
        tmp0 += d9 * D0D9;
        tmp0 += d10 * D0D10;
        tmp0 += d11 * D0D11;
        result += d0 * tmp0;

        var tmp1 = 0.0;
        tmp1 += d0 * D0D1;
        tmp1 += d1 * D1D1;
        tmp1 += d2 * D1D2;
        tmp1 += d3 * D1D3;
        tmp1 += d4 * D1D4;
        tmp1 += d5 * D1D5;
        tmp1 += d6 * D1D6;
        tmp1 += d7 * D1D7;
        tmp1 += d8 * D1D8;
        tmp1 += d9 * D1D9;
        tmp1 += d10 * D1D10;
        tmp1 += d11 * D1D11;
        result += d1 * tmp1;

        var tmp2 = 0.0;
        tmp2 += d0 * D0D2;
        tmp2 += d1 * D1D2;
        tmp2 += d2 * D2D2;
        tmp2 += d3 * D2D3;
        tmp2 += d4 * D2D4;
        tmp2 += d5 * D2D5;
        tmp2 += d6 * D2D6;
        tmp2 += d7 * D2D7;
        tmp2 += d8 * D2D8;
        tmp2 += d9 * D2D9;
        tmp2 += d10 * D2D10;
        tmp2 += d11 * D2D11;
        result += d2 * tmp2;

        var tmp3 = 0.0;
        tmp3 += d0 * D0D3;
        tmp3 += d1 * D1D3;
        tmp3 += d2 * D2D3;
        tmp3 += d3 * D3D3;
        tmp3 += d4 * D3D4;
        tmp3 += d5 * D3D5;
        tmp3 += d6 * D3D6;
        tmp3 += d7 * D3D7;
        tmp3 += d8 * D3D8;
        tmp3 += d9 * D3D9;
        tmp3 += d10 * D3D10;
        tmp3 += d11 * D3D11;
        result += d3 * tmp3;

        var tmp4 = 0.0;
        tmp4 += d0 * D0D4;
        tmp4 += d1 * D1D4;
        tmp4 += d2 * D2D4;
        tmp4 += d3 * D3D4;
        tmp4 += d4 * D4D4;
        tmp4 += d5 * D4D5;
        tmp4 += d6 * D4D6;
        tmp4 += d7 * D4D7;
        tmp4 += d8 * D4D8;
        tmp4 += d9 * D4D9;
        tmp4 += d10 * D4D10;
        tmp4 += d11 * D4D11;
        result += d4 * tmp4;

        var tmp5 = 0.0;
        tmp5 += d0 * D0D5;
        tmp5 += d1 * D1D5;
        tmp5 += d2 * D2D5;
        tmp5 += d3 * D3D5;
        tmp5 += d4 * D4D5;
        tmp5 += d5 * D5D5;
        tmp5 += d6 * D5D6;
        tmp5 += d7 * D5D7;
        tmp5 += d8 * D5D8;
        tmp5 += d9 * D5D9;
        tmp5 += d10 * D5D10;
        tmp5 += d11 * D5D11;
        result += d5 * tmp5;

        var tmp6 = 0.0;
        tmp6 += d0 * D0D6;
        tmp6 += d1 * D1D6;
        tmp6 += d2 * D2D6;
        tmp6 += d3 * D3D6;
        tmp6 += d4 * D4D6;
        tmp6 += d5 * D5D6;
        tmp6 += d6 * D6D6;
        tmp6 += d7 * D6D7;
        tmp6 += d8 * D6D8;
        tmp6 += d9 * D6D9;
        tmp6 += d10 * D6D10;
        tmp6 += d11 * D6D11;
        result += d6 * tmp6;

        var tmp7 = 0.0;
        tmp7 += d0 * D0D7;
        tmp7 += d1 * D1D7;
        tmp7 += d2 * D2D7;
        tmp7 += d3 * D3D7;
        tmp7 += d4 * D4D7;
        tmp7 += d5 * D5D7;
        tmp7 += d6 * D6D7;
        tmp7 += d7 * D7D7;
        tmp7 += d8 * D7D8;
        tmp7 += d9 * D7D9;
        tmp7 += d10 * D7D10;
        tmp7 += d11 * D7D11;
        result += d7 * tmp7;

        var tmp8 = 0.0;
        tmp8 += d0 * D0D8;
        tmp8 += d1 * D1D8;
        tmp8 += d2 * D2D8;
        tmp8 += d3 * D3D8;
        tmp8 += d4 * D4D8;
        tmp8 += d5 * D5D8;
        tmp8 += d6 * D6D8;
        tmp8 += d7 * D7D8;
        tmp8 += d8 * D8D8;
        tmp8 += d9 * D8D9;
        tmp8 += d10 * D8D10;
        tmp8 += d11 * D8D11;
        result += d8 * tmp8;

        var tmp9 = 0.0;
        tmp9 += d0 * D0D9;
        tmp9 += d1 * D1D9;
        tmp9 += d2 * D2D9;
        tmp9 += d3 * D3D9;
        tmp9 += d4 * D4D9;
        tmp9 += d5 * D5D9;
        tmp9 += d6 * D6D9;
        tmp9 += d7 * D7D9;
        tmp9 += d8 * D8D9;
        tmp9 += d9 * D9D9;
        tmp9 += d10 * D9D10;
        tmp9 += d11 * D9D11;
        result += d9 * tmp9;

        var tmp10 = 0.0;
        tmp10 += d0 * D0D10;
        tmp10 += d1 * D1D10;
        tmp10 += d2 * D2D10;
        tmp10 += d3 * D3D10;
        tmp10 += d4 * D4D10;
        tmp10 += d5 * D5D10;
        tmp10 += d6 * D6D10;
        tmp10 += d7 * D7D10;
        tmp10 += d8 * D8D10;
        tmp10 += d9 * D9D10;
        tmp10 += d10 * D10D10;
        tmp10 += d11 * D10D11;
        result += d10 * tmp10;

        var tmp11 = 0.0;
        tmp11 += d0 * D0D11;
        tmp11 += d1 * D1D11;
        tmp11 += d2 * D2D11;
        tmp11 += d3 * D3D11;
        tmp11 += d4 * D4D11;
        tmp11 += d5 * D5D11;
        tmp11 += d6 * D6D11;
        tmp11 += d7 * D7D11;
        tmp11 += d8 * D8D11;
        tmp11 += d9 * D9D11;
        tmp11 += d10 * D10D11;
        tmp11 += d11 * D11D11;
        result += d11 * tmp11;

        result *= 0.5;
        result += Constant;
        
        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;
        result += D3 * d3;
        result += D4 * d4;
        result += D5 * d5;
        result += D6 * d6;
        result += D7 * d7;
        result += D8 * d8;
        result += D9 * d9;
        result += D10 * d10;
        result += D11 * d11;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(DD12Scalar lhs, DD12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as DD12Scalar);
	}

	public bool Equals(DD12Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(DD12Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 12;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 91);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 91)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 12)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }
    
	public ref double DD(int i)
	{
		if (i >= 78)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, i);
	}
    
	public ref double DD(int i, int j)
	{
        var idx = i < j
            ? (23 - i) * i / 2 + j
            : (23 - j) * j / 2 + i;

		if (idx >= 78)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0D0, idx);
	}

    // Transformations

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar Forward(double constant, double da, double dada, DD12Scalar a)
    {
        var result = new DD12Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        result.D9 = da * a.D9;
        result.D10 = da * a.D10;
        result.D11 = da * a.D11;

        var ca0 = dada * a.D0;
        var ca1 = dada * a.D1;
        var ca2 = dada * a.D2;
        var ca3 = dada * a.D3;
        var ca4 = dada * a.D4;
        var ca5 = dada * a.D5;
        var ca6 = dada * a.D6;
        var ca7 = dada * a.D7;
        var ca8 = dada * a.D8;
        var ca9 = dada * a.D9;
        var ca10 = dada * a.D10;
        var ca11 = dada * a.D11;

        result.D0D0 = da * a.D0D0 + ca0 * a.D0;
        result.D0D1 = da * a.D0D1 + ca0 * a.D1;
        result.D0D2 = da * a.D0D2 + ca0 * a.D2;
        result.D0D3 = da * a.D0D3 + ca0 * a.D3;
        result.D0D4 = da * a.D0D4 + ca0 * a.D4;
        result.D0D5 = da * a.D0D5 + ca0 * a.D5;
        result.D0D6 = da * a.D0D6 + ca0 * a.D6;
        result.D0D7 = da * a.D0D7 + ca0 * a.D7;
        result.D0D8 = da * a.D0D8 + ca0 * a.D8;
        result.D0D9 = da * a.D0D9 + ca0 * a.D9;
        result.D0D10 = da * a.D0D10 + ca0 * a.D10;
        result.D0D11 = da * a.D0D11 + ca0 * a.D11;
        result.D1D1 = da * a.D1D1 + ca1 * a.D1;
        result.D1D2 = da * a.D1D2 + ca1 * a.D2;
        result.D1D3 = da * a.D1D3 + ca1 * a.D3;
        result.D1D4 = da * a.D1D4 + ca1 * a.D4;
        result.D1D5 = da * a.D1D5 + ca1 * a.D5;
        result.D1D6 = da * a.D1D6 + ca1 * a.D6;
        result.D1D7 = da * a.D1D7 + ca1 * a.D7;
        result.D1D8 = da * a.D1D8 + ca1 * a.D8;
        result.D1D9 = da * a.D1D9 + ca1 * a.D9;
        result.D1D10 = da * a.D1D10 + ca1 * a.D10;
        result.D1D11 = da * a.D1D11 + ca1 * a.D11;
        result.D2D2 = da * a.D2D2 + ca2 * a.D2;
        result.D2D3 = da * a.D2D3 + ca2 * a.D3;
        result.D2D4 = da * a.D2D4 + ca2 * a.D4;
        result.D2D5 = da * a.D2D5 + ca2 * a.D5;
        result.D2D6 = da * a.D2D6 + ca2 * a.D6;
        result.D2D7 = da * a.D2D7 + ca2 * a.D7;
        result.D2D8 = da * a.D2D8 + ca2 * a.D8;
        result.D2D9 = da * a.D2D9 + ca2 * a.D9;
        result.D2D10 = da * a.D2D10 + ca2 * a.D10;
        result.D2D11 = da * a.D2D11 + ca2 * a.D11;
        result.D3D3 = da * a.D3D3 + ca3 * a.D3;
        result.D3D4 = da * a.D3D4 + ca3 * a.D4;
        result.D3D5 = da * a.D3D5 + ca3 * a.D5;
        result.D3D6 = da * a.D3D6 + ca3 * a.D6;
        result.D3D7 = da * a.D3D7 + ca3 * a.D7;
        result.D3D8 = da * a.D3D8 + ca3 * a.D8;
        result.D3D9 = da * a.D3D9 + ca3 * a.D9;
        result.D3D10 = da * a.D3D10 + ca3 * a.D10;
        result.D3D11 = da * a.D3D11 + ca3 * a.D11;
        result.D4D4 = da * a.D4D4 + ca4 * a.D4;
        result.D4D5 = da * a.D4D5 + ca4 * a.D5;
        result.D4D6 = da * a.D4D6 + ca4 * a.D6;
        result.D4D7 = da * a.D4D7 + ca4 * a.D7;
        result.D4D8 = da * a.D4D8 + ca4 * a.D8;
        result.D4D9 = da * a.D4D9 + ca4 * a.D9;
        result.D4D10 = da * a.D4D10 + ca4 * a.D10;
        result.D4D11 = da * a.D4D11 + ca4 * a.D11;
        result.D5D5 = da * a.D5D5 + ca5 * a.D5;
        result.D5D6 = da * a.D5D6 + ca5 * a.D6;
        result.D5D7 = da * a.D5D7 + ca5 * a.D7;
        result.D5D8 = da * a.D5D8 + ca5 * a.D8;
        result.D5D9 = da * a.D5D9 + ca5 * a.D9;
        result.D5D10 = da * a.D5D10 + ca5 * a.D10;
        result.D5D11 = da * a.D5D11 + ca5 * a.D11;
        result.D6D6 = da * a.D6D6 + ca6 * a.D6;
        result.D6D7 = da * a.D6D7 + ca6 * a.D7;
        result.D6D8 = da * a.D6D8 + ca6 * a.D8;
        result.D6D9 = da * a.D6D9 + ca6 * a.D9;
        result.D6D10 = da * a.D6D10 + ca6 * a.D10;
        result.D6D11 = da * a.D6D11 + ca6 * a.D11;
        result.D7D7 = da * a.D7D7 + ca7 * a.D7;
        result.D7D8 = da * a.D7D8 + ca7 * a.D8;
        result.D7D9 = da * a.D7D9 + ca7 * a.D9;
        result.D7D10 = da * a.D7D10 + ca7 * a.D10;
        result.D7D11 = da * a.D7D11 + ca7 * a.D11;
        result.D8D8 = da * a.D8D8 + ca8 * a.D8;
        result.D8D9 = da * a.D8D9 + ca8 * a.D9;
        result.D8D10 = da * a.D8D10 + ca8 * a.D10;
        result.D8D11 = da * a.D8D11 + ca8 * a.D11;
        result.D9D9 = da * a.D9D9 + ca9 * a.D9;
        result.D9D10 = da * a.D9D10 + ca9 * a.D10;
        result.D9D11 = da * a.D9D11 + ca9 * a.D11;
        result.D10D10 = da * a.D10D10 + ca10 * a.D10;
        result.D10D11 = da * a.D10D11 + ca10 * a.D11;
        result.D11D11 = da * a.D11D11 + ca11 * a.D11;

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar Forward(double constant, double da, double db, double dada, double dadb, double dbdb, DD12Scalar a, DD12Scalar b)
    {
        var result = new DD12Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        result.D9 = da * a.D9 + db * b.D9;
        result.D10 = da * a.D10 + db * b.D10;
        result.D11 = da * a.D11 + db * b.D11;

        var ca0 = dada * a.D0 + dadb * b.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0;
        var ca1 = dada * a.D1 + dadb * b.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1;
        var ca2 = dada * a.D2 + dadb * b.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2;
        var ca3 = dada * a.D3 + dadb * b.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3;
        var ca4 = dada * a.D4 + dadb * b.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4;
        var ca5 = dada * a.D5 + dadb * b.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5;
        var ca6 = dada * a.D6 + dadb * b.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6;
        var ca7 = dada * a.D7 + dadb * b.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7;
        var ca8 = dada * a.D8 + dadb * b.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8;
        var ca9 = dada * a.D9 + dadb * b.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9;
        var ca10 = dada * a.D10 + dadb * b.D10;
        var cb10 = dadb * a.D10 + dbdb * b.D10;
        var ca11 = dada * a.D11 + dadb * b.D11;
        var cb11 = dadb * a.D11 + dbdb * b.D11;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + ca0 * a.D0 + cb0 * b.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + ca0 * a.D1 + cb0 * b.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + ca0 * a.D2 + cb0 * b.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + ca0 * a.D3 + cb0 * b.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + ca0 * a.D4 + cb0 * b.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + ca0 * a.D5 + cb0 * b.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + ca0 * a.D6 + cb0 * b.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + ca0 * a.D7 + cb0 * b.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + ca0 * a.D8 + cb0 * b.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + ca0 * a.D9 + cb0 * b.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + ca0 * a.D10 + cb0 * b.D10;
        result.D0D11 = da * a.D0D11 + db * b.D0D11 + ca0 * a.D11 + cb0 * b.D11;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + ca1 * a.D1 + cb1 * b.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + ca1 * a.D2 + cb1 * b.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + ca1 * a.D3 + cb1 * b.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + ca1 * a.D4 + cb1 * b.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + ca1 * a.D5 + cb1 * b.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + ca1 * a.D6 + cb1 * b.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + ca1 * a.D7 + cb1 * b.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + ca1 * a.D8 + cb1 * b.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + ca1 * a.D9 + cb1 * b.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + ca1 * a.D10 + cb1 * b.D10;
        result.D1D11 = da * a.D1D11 + db * b.D1D11 + ca1 * a.D11 + cb1 * b.D11;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + ca2 * a.D2 + cb2 * b.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + ca2 * a.D3 + cb2 * b.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + ca2 * a.D4 + cb2 * b.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + ca2 * a.D5 + cb2 * b.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + ca2 * a.D6 + cb2 * b.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + ca2 * a.D7 + cb2 * b.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + ca2 * a.D8 + cb2 * b.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + ca2 * a.D9 + cb2 * b.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + ca2 * a.D10 + cb2 * b.D10;
        result.D2D11 = da * a.D2D11 + db * b.D2D11 + ca2 * a.D11 + cb2 * b.D11;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + ca3 * a.D3 + cb3 * b.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + ca3 * a.D4 + cb3 * b.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + ca3 * a.D5 + cb3 * b.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + ca3 * a.D6 + cb3 * b.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + ca3 * a.D7 + cb3 * b.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + ca3 * a.D8 + cb3 * b.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + ca3 * a.D9 + cb3 * b.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + ca3 * a.D10 + cb3 * b.D10;
        result.D3D11 = da * a.D3D11 + db * b.D3D11 + ca3 * a.D11 + cb3 * b.D11;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + ca4 * a.D4 + cb4 * b.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + ca4 * a.D5 + cb4 * b.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + ca4 * a.D6 + cb4 * b.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + ca4 * a.D7 + cb4 * b.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + ca4 * a.D8 + cb4 * b.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + ca4 * a.D9 + cb4 * b.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + ca4 * a.D10 + cb4 * b.D10;
        result.D4D11 = da * a.D4D11 + db * b.D4D11 + ca4 * a.D11 + cb4 * b.D11;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + ca5 * a.D5 + cb5 * b.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + ca5 * a.D6 + cb5 * b.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + ca5 * a.D7 + cb5 * b.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + ca5 * a.D8 + cb5 * b.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + ca5 * a.D9 + cb5 * b.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + ca5 * a.D10 + cb5 * b.D10;
        result.D5D11 = da * a.D5D11 + db * b.D5D11 + ca5 * a.D11 + cb5 * b.D11;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + ca6 * a.D6 + cb6 * b.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + ca6 * a.D7 + cb6 * b.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + ca6 * a.D8 + cb6 * b.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + ca6 * a.D9 + cb6 * b.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + ca6 * a.D10 + cb6 * b.D10;
        result.D6D11 = da * a.D6D11 + db * b.D6D11 + ca6 * a.D11 + cb6 * b.D11;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + ca7 * a.D7 + cb7 * b.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + ca7 * a.D8 + cb7 * b.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + ca7 * a.D9 + cb7 * b.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + ca7 * a.D10 + cb7 * b.D10;
        result.D7D11 = da * a.D7D11 + db * b.D7D11 + ca7 * a.D11 + cb7 * b.D11;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + ca8 * a.D8 + cb8 * b.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + ca8 * a.D9 + cb8 * b.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + ca8 * a.D10 + cb8 * b.D10;
        result.D8D11 = da * a.D8D11 + db * b.D8D11 + ca8 * a.D11 + cb8 * b.D11;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + ca9 * a.D9 + cb9 * b.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + ca9 * a.D10 + cb9 * b.D10;
        result.D9D11 = da * a.D9D11 + db * b.D9D11 + ca9 * a.D11 + cb9 * b.D11;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + ca10 * a.D10 + cb10 * b.D10;
        result.D10D11 = da * a.D10D11 + db * b.D10D11 + ca10 * a.D11 + cb10 * b.D11;
        result.D11D11 = da * a.D11D11 + db * b.D11D11 + ca11 * a.D11 + cb11 * b.D11;

        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar Forward(double constant, double da, double db, double dc, double dada, double dadb, double dadc, double dbdb, double dbdc, double dcdc, DD12Scalar a, DD12Scalar b, DD12Scalar c)
    {
        var result = new DD12Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        result.D8 = da * a.D8 + db * b.D8 + dc * c.D8;
        result.D9 = da * a.D9 + db * b.D9 + dc * c.D9;
        result.D10 = da * a.D10 + db * b.D10 + dc * c.D10;
        result.D11 = da * a.D11 + db * b.D11 + dc * c.D11;

        var ca0 = dada * a.D0 + dadb * b.D0 + dadc * c.D0;
        var cb0 = dadb * a.D0 + dbdb * b.D0 + dbdc * c.D0;
        var cc0 = dadc * a.D0 + dbdc * b.D0 + dcdc * c.D0;
        var ca1 = dada * a.D1 + dadb * b.D1 + dadc * c.D1;
        var cb1 = dadb * a.D1 + dbdb * b.D1 + dbdc * c.D1;
        var cc1 = dadc * a.D1 + dbdc * b.D1 + dcdc * c.D1;
        var ca2 = dada * a.D2 + dadb * b.D2 + dadc * c.D2;
        var cb2 = dadb * a.D2 + dbdb * b.D2 + dbdc * c.D2;
        var cc2 = dadc * a.D2 + dbdc * b.D2 + dcdc * c.D2;
        var ca3 = dada * a.D3 + dadb * b.D3 + dadc * c.D3;
        var cb3 = dadb * a.D3 + dbdb * b.D3 + dbdc * c.D3;
        var cc3 = dadc * a.D3 + dbdc * b.D3 + dcdc * c.D3;
        var ca4 = dada * a.D4 + dadb * b.D4 + dadc * c.D4;
        var cb4 = dadb * a.D4 + dbdb * b.D4 + dbdc * c.D4;
        var cc4 = dadc * a.D4 + dbdc * b.D4 + dcdc * c.D4;
        var ca5 = dada * a.D5 + dadb * b.D5 + dadc * c.D5;
        var cb5 = dadb * a.D5 + dbdb * b.D5 + dbdc * c.D5;
        var cc5 = dadc * a.D5 + dbdc * b.D5 + dcdc * c.D5;
        var ca6 = dada * a.D6 + dadb * b.D6 + dadc * c.D6;
        var cb6 = dadb * a.D6 + dbdb * b.D6 + dbdc * c.D6;
        var cc6 = dadc * a.D6 + dbdc * b.D6 + dcdc * c.D6;
        var ca7 = dada * a.D7 + dadb * b.D7 + dadc * c.D7;
        var cb7 = dadb * a.D7 + dbdb * b.D7 + dbdc * c.D7;
        var cc7 = dadc * a.D7 + dbdc * b.D7 + dcdc * c.D7;
        var ca8 = dada * a.D8 + dadb * b.D8 + dadc * c.D8;
        var cb8 = dadb * a.D8 + dbdb * b.D8 + dbdc * c.D8;
        var cc8 = dadc * a.D8 + dbdc * b.D8 + dcdc * c.D8;
        var ca9 = dada * a.D9 + dadb * b.D9 + dadc * c.D9;
        var cb9 = dadb * a.D9 + dbdb * b.D9 + dbdc * c.D9;
        var cc9 = dadc * a.D9 + dbdc * b.D9 + dcdc * c.D9;
        var ca10 = dada * a.D10 + dadb * b.D10 + dadc * c.D10;
        var cb10 = dadb * a.D10 + dbdb * b.D10 + dbdc * c.D10;
        var cc10 = dadc * a.D10 + dbdc * b.D10 + dcdc * c.D10;
        var ca11 = dada * a.D11 + dadb * b.D11 + dadc * c.D11;
        var cb11 = dadb * a.D11 + dbdb * b.D11 + dbdc * c.D11;
        var cc11 = dadc * a.D11 + dbdc * b.D11 + dcdc * c.D11;

        result.D0D0 = da * a.D0D0 + db * b.D0D0 + dc * c.D0D0 + ca0 * a.D0 + cb0 * b.D0 + cc0 * c.D0;
        result.D0D1 = da * a.D0D1 + db * b.D0D1 + dc * c.D0D1 + ca0 * a.D1 + cb0 * b.D1 + cc0 * c.D1;
        result.D0D2 = da * a.D0D2 + db * b.D0D2 + dc * c.D0D2 + ca0 * a.D2 + cb0 * b.D2 + cc0 * c.D2;
        result.D0D3 = da * a.D0D3 + db * b.D0D3 + dc * c.D0D3 + ca0 * a.D3 + cb0 * b.D3 + cc0 * c.D3;
        result.D0D4 = da * a.D0D4 + db * b.D0D4 + dc * c.D0D4 + ca0 * a.D4 + cb0 * b.D4 + cc0 * c.D4;
        result.D0D5 = da * a.D0D5 + db * b.D0D5 + dc * c.D0D5 + ca0 * a.D5 + cb0 * b.D5 + cc0 * c.D5;
        result.D0D6 = da * a.D0D6 + db * b.D0D6 + dc * c.D0D6 + ca0 * a.D6 + cb0 * b.D6 + cc0 * c.D6;
        result.D0D7 = da * a.D0D7 + db * b.D0D7 + dc * c.D0D7 + ca0 * a.D7 + cb0 * b.D7 + cc0 * c.D7;
        result.D0D8 = da * a.D0D8 + db * b.D0D8 + dc * c.D0D8 + ca0 * a.D8 + cb0 * b.D8 + cc0 * c.D8;
        result.D0D9 = da * a.D0D9 + db * b.D0D9 + dc * c.D0D9 + ca0 * a.D9 + cb0 * b.D9 + cc0 * c.D9;
        result.D0D10 = da * a.D0D10 + db * b.D0D10 + dc * c.D0D10 + ca0 * a.D10 + cb0 * b.D10 + cc0 * c.D10;
        result.D0D11 = da * a.D0D11 + db * b.D0D11 + dc * c.D0D11 + ca0 * a.D11 + cb0 * b.D11 + cc0 * c.D11;
        result.D1D1 = da * a.D1D1 + db * b.D1D1 + dc * c.D1D1 + ca1 * a.D1 + cb1 * b.D1 + cc1 * c.D1;
        result.D1D2 = da * a.D1D2 + db * b.D1D2 + dc * c.D1D2 + ca1 * a.D2 + cb1 * b.D2 + cc1 * c.D2;
        result.D1D3 = da * a.D1D3 + db * b.D1D3 + dc * c.D1D3 + ca1 * a.D3 + cb1 * b.D3 + cc1 * c.D3;
        result.D1D4 = da * a.D1D4 + db * b.D1D4 + dc * c.D1D4 + ca1 * a.D4 + cb1 * b.D4 + cc1 * c.D4;
        result.D1D5 = da * a.D1D5 + db * b.D1D5 + dc * c.D1D5 + ca1 * a.D5 + cb1 * b.D5 + cc1 * c.D5;
        result.D1D6 = da * a.D1D6 + db * b.D1D6 + dc * c.D1D6 + ca1 * a.D6 + cb1 * b.D6 + cc1 * c.D6;
        result.D1D7 = da * a.D1D7 + db * b.D1D7 + dc * c.D1D7 + ca1 * a.D7 + cb1 * b.D7 + cc1 * c.D7;
        result.D1D8 = da * a.D1D8 + db * b.D1D8 + dc * c.D1D8 + ca1 * a.D8 + cb1 * b.D8 + cc1 * c.D8;
        result.D1D9 = da * a.D1D9 + db * b.D1D9 + dc * c.D1D9 + ca1 * a.D9 + cb1 * b.D9 + cc1 * c.D9;
        result.D1D10 = da * a.D1D10 + db * b.D1D10 + dc * c.D1D10 + ca1 * a.D10 + cb1 * b.D10 + cc1 * c.D10;
        result.D1D11 = da * a.D1D11 + db * b.D1D11 + dc * c.D1D11 + ca1 * a.D11 + cb1 * b.D11 + cc1 * c.D11;
        result.D2D2 = da * a.D2D2 + db * b.D2D2 + dc * c.D2D2 + ca2 * a.D2 + cb2 * b.D2 + cc2 * c.D2;
        result.D2D3 = da * a.D2D3 + db * b.D2D3 + dc * c.D2D3 + ca2 * a.D3 + cb2 * b.D3 + cc2 * c.D3;
        result.D2D4 = da * a.D2D4 + db * b.D2D4 + dc * c.D2D4 + ca2 * a.D4 + cb2 * b.D4 + cc2 * c.D4;
        result.D2D5 = da * a.D2D5 + db * b.D2D5 + dc * c.D2D5 + ca2 * a.D5 + cb2 * b.D5 + cc2 * c.D5;
        result.D2D6 = da * a.D2D6 + db * b.D2D6 + dc * c.D2D6 + ca2 * a.D6 + cb2 * b.D6 + cc2 * c.D6;
        result.D2D7 = da * a.D2D7 + db * b.D2D7 + dc * c.D2D7 + ca2 * a.D7 + cb2 * b.D7 + cc2 * c.D7;
        result.D2D8 = da * a.D2D8 + db * b.D2D8 + dc * c.D2D8 + ca2 * a.D8 + cb2 * b.D8 + cc2 * c.D8;
        result.D2D9 = da * a.D2D9 + db * b.D2D9 + dc * c.D2D9 + ca2 * a.D9 + cb2 * b.D9 + cc2 * c.D9;
        result.D2D10 = da * a.D2D10 + db * b.D2D10 + dc * c.D2D10 + ca2 * a.D10 + cb2 * b.D10 + cc2 * c.D10;
        result.D2D11 = da * a.D2D11 + db * b.D2D11 + dc * c.D2D11 + ca2 * a.D11 + cb2 * b.D11 + cc2 * c.D11;
        result.D3D3 = da * a.D3D3 + db * b.D3D3 + dc * c.D3D3 + ca3 * a.D3 + cb3 * b.D3 + cc3 * c.D3;
        result.D3D4 = da * a.D3D4 + db * b.D3D4 + dc * c.D3D4 + ca3 * a.D4 + cb3 * b.D4 + cc3 * c.D4;
        result.D3D5 = da * a.D3D5 + db * b.D3D5 + dc * c.D3D5 + ca3 * a.D5 + cb3 * b.D5 + cc3 * c.D5;
        result.D3D6 = da * a.D3D6 + db * b.D3D6 + dc * c.D3D6 + ca3 * a.D6 + cb3 * b.D6 + cc3 * c.D6;
        result.D3D7 = da * a.D3D7 + db * b.D3D7 + dc * c.D3D7 + ca3 * a.D7 + cb3 * b.D7 + cc3 * c.D7;
        result.D3D8 = da * a.D3D8 + db * b.D3D8 + dc * c.D3D8 + ca3 * a.D8 + cb3 * b.D8 + cc3 * c.D8;
        result.D3D9 = da * a.D3D9 + db * b.D3D9 + dc * c.D3D9 + ca3 * a.D9 + cb3 * b.D9 + cc3 * c.D9;
        result.D3D10 = da * a.D3D10 + db * b.D3D10 + dc * c.D3D10 + ca3 * a.D10 + cb3 * b.D10 + cc3 * c.D10;
        result.D3D11 = da * a.D3D11 + db * b.D3D11 + dc * c.D3D11 + ca3 * a.D11 + cb3 * b.D11 + cc3 * c.D11;
        result.D4D4 = da * a.D4D4 + db * b.D4D4 + dc * c.D4D4 + ca4 * a.D4 + cb4 * b.D4 + cc4 * c.D4;
        result.D4D5 = da * a.D4D5 + db * b.D4D5 + dc * c.D4D5 + ca4 * a.D5 + cb4 * b.D5 + cc4 * c.D5;
        result.D4D6 = da * a.D4D6 + db * b.D4D6 + dc * c.D4D6 + ca4 * a.D6 + cb4 * b.D6 + cc4 * c.D6;
        result.D4D7 = da * a.D4D7 + db * b.D4D7 + dc * c.D4D7 + ca4 * a.D7 + cb4 * b.D7 + cc4 * c.D7;
        result.D4D8 = da * a.D4D8 + db * b.D4D8 + dc * c.D4D8 + ca4 * a.D8 + cb4 * b.D8 + cc4 * c.D8;
        result.D4D9 = da * a.D4D9 + db * b.D4D9 + dc * c.D4D9 + ca4 * a.D9 + cb4 * b.D9 + cc4 * c.D9;
        result.D4D10 = da * a.D4D10 + db * b.D4D10 + dc * c.D4D10 + ca4 * a.D10 + cb4 * b.D10 + cc4 * c.D10;
        result.D4D11 = da * a.D4D11 + db * b.D4D11 + dc * c.D4D11 + ca4 * a.D11 + cb4 * b.D11 + cc4 * c.D11;
        result.D5D5 = da * a.D5D5 + db * b.D5D5 + dc * c.D5D5 + ca5 * a.D5 + cb5 * b.D5 + cc5 * c.D5;
        result.D5D6 = da * a.D5D6 + db * b.D5D6 + dc * c.D5D6 + ca5 * a.D6 + cb5 * b.D6 + cc5 * c.D6;
        result.D5D7 = da * a.D5D7 + db * b.D5D7 + dc * c.D5D7 + ca5 * a.D7 + cb5 * b.D7 + cc5 * c.D7;
        result.D5D8 = da * a.D5D8 + db * b.D5D8 + dc * c.D5D8 + ca5 * a.D8 + cb5 * b.D8 + cc5 * c.D8;
        result.D5D9 = da * a.D5D9 + db * b.D5D9 + dc * c.D5D9 + ca5 * a.D9 + cb5 * b.D9 + cc5 * c.D9;
        result.D5D10 = da * a.D5D10 + db * b.D5D10 + dc * c.D5D10 + ca5 * a.D10 + cb5 * b.D10 + cc5 * c.D10;
        result.D5D11 = da * a.D5D11 + db * b.D5D11 + dc * c.D5D11 + ca5 * a.D11 + cb5 * b.D11 + cc5 * c.D11;
        result.D6D6 = da * a.D6D6 + db * b.D6D6 + dc * c.D6D6 + ca6 * a.D6 + cb6 * b.D6 + cc6 * c.D6;
        result.D6D7 = da * a.D6D7 + db * b.D6D7 + dc * c.D6D7 + ca6 * a.D7 + cb6 * b.D7 + cc6 * c.D7;
        result.D6D8 = da * a.D6D8 + db * b.D6D8 + dc * c.D6D8 + ca6 * a.D8 + cb6 * b.D8 + cc6 * c.D8;
        result.D6D9 = da * a.D6D9 + db * b.D6D9 + dc * c.D6D9 + ca6 * a.D9 + cb6 * b.D9 + cc6 * c.D9;
        result.D6D10 = da * a.D6D10 + db * b.D6D10 + dc * c.D6D10 + ca6 * a.D10 + cb6 * b.D10 + cc6 * c.D10;
        result.D6D11 = da * a.D6D11 + db * b.D6D11 + dc * c.D6D11 + ca6 * a.D11 + cb6 * b.D11 + cc6 * c.D11;
        result.D7D7 = da * a.D7D7 + db * b.D7D7 + dc * c.D7D7 + ca7 * a.D7 + cb7 * b.D7 + cc7 * c.D7;
        result.D7D8 = da * a.D7D8 + db * b.D7D8 + dc * c.D7D8 + ca7 * a.D8 + cb7 * b.D8 + cc7 * c.D8;
        result.D7D9 = da * a.D7D9 + db * b.D7D9 + dc * c.D7D9 + ca7 * a.D9 + cb7 * b.D9 + cc7 * c.D9;
        result.D7D10 = da * a.D7D10 + db * b.D7D10 + dc * c.D7D10 + ca7 * a.D10 + cb7 * b.D10 + cc7 * c.D10;
        result.D7D11 = da * a.D7D11 + db * b.D7D11 + dc * c.D7D11 + ca7 * a.D11 + cb7 * b.D11 + cc7 * c.D11;
        result.D8D8 = da * a.D8D8 + db * b.D8D8 + dc * c.D8D8 + ca8 * a.D8 + cb8 * b.D8 + cc8 * c.D8;
        result.D8D9 = da * a.D8D9 + db * b.D8D9 + dc * c.D8D9 + ca8 * a.D9 + cb8 * b.D9 + cc8 * c.D9;
        result.D8D10 = da * a.D8D10 + db * b.D8D10 + dc * c.D8D10 + ca8 * a.D10 + cb8 * b.D10 + cc8 * c.D10;
        result.D8D11 = da * a.D8D11 + db * b.D8D11 + dc * c.D8D11 + ca8 * a.D11 + cb8 * b.D11 + cc8 * c.D11;
        result.D9D9 = da * a.D9D9 + db * b.D9D9 + dc * c.D9D9 + ca9 * a.D9 + cb9 * b.D9 + cc9 * c.D9;
        result.D9D10 = da * a.D9D10 + db * b.D9D10 + dc * c.D9D10 + ca9 * a.D10 + cb9 * b.D10 + cc9 * c.D10;
        result.D9D11 = da * a.D9D11 + db * b.D9D11 + dc * c.D9D11 + ca9 * a.D11 + cb9 * b.D11 + cc9 * c.D11;
        result.D10D10 = da * a.D10D10 + db * b.D10D10 + dc * c.D10D10 + ca10 * a.D10 + cb10 * b.D10 + cc10 * c.D10;
        result.D10D11 = da * a.D10D11 + db * b.D10D11 + dc * c.D10D11 + ca10 * a.D11 + cb10 * b.D11 + cc10 * c.D11;
        result.D11D11 = da * a.D11D11 + db * b.D11D11 + dc * c.D11D11 + ca11 * a.D11 + cb11 * b.D11 + cc11 * c.D11;

        return result;
    }

    // neg

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator -(DD12Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator +(DD12Scalar lhs, DD12Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator +(double lhs, DD12Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator +(DD12Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator -(DD12Scalar lhs, DD12Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator -(double lhs, DD12Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator -(DD12Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator *(DD12Scalar lhs, DD12Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator *(double lhs, DD12Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator *(DD12Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator /(DD12Scalar lhs, DD12Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator /(double lhs, DD12Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DD12Scalar operator /(DD12Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}
