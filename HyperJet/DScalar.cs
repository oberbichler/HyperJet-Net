#pragma warning disable IDE0017

namespace HyperJet;

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D1Scalar : IScalar, IEquatable<D1Scalar>, IComparable<D1Scalar>
{
    public double Constant;
    public double D0;

    public D1Scalar()
    {
    }

    public D1Scalar(double constant)
    {
        Constant = constant;
    }

    public D1Scalar(double constant, double d0)
    {
        Constant = constant;
        D0 = d0;
    }
    
    public D1Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
    }

    public static D1Scalar Variable(double constant)
    {
        var result = new D1Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public double Evaluate(double d0)
    {
        var result = Constant;

        result += D0 * d0;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D1Scalar lhs, D1Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D1Scalar);
	}

	public bool Equals(D1Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D1Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 1;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 2);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 2)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 1)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D1Scalar Forward(double constant, double da, D1Scalar a)
    {
        var result = new D1Scalar(constant);
        result.D0 = da * a.D0;
        return result;
    }

    public static D1Scalar Forward(double constant, double da, double db, D1Scalar a, D1Scalar b)
    {
        var result = new D1Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        return result;
    }
    
    public static D1Scalar Forward(double constant, double da, double db, double dc, D1Scalar a, D1Scalar b, D1Scalar c)
    {
        var result = new D1Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        return result;
    }

    // neg

    public static D1Scalar operator -(D1Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D1Scalar operator +(D1Scalar lhs, D1Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D1Scalar operator +(double lhs, D1Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D1Scalar operator +(D1Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D1Scalar operator -(D1Scalar lhs, D1Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D1Scalar operator -(double lhs, D1Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D1Scalar operator -(D1Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D1Scalar operator *(D1Scalar lhs, D1Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D1Scalar operator *(double lhs, D1Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D1Scalar operator *(D1Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D1Scalar operator /(D1Scalar lhs, D1Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D1Scalar operator /(double lhs, D1Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D1Scalar operator /(D1Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D2Scalar : IScalar, IEquatable<D2Scalar>, IComparable<D2Scalar>
{
    public double Constant;
    public double D0;
    public double D1;

    public D2Scalar()
    {
    }

    public D2Scalar(double constant)
    {
        Constant = constant;
    }

    public D2Scalar(double constant, double d0, double d1)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
    }
    
    public D2Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
    }

    public static D2Scalar Variable0(double constant)
    {
        var result = new D2Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D2Scalar Variable1(double constant)
    {
        var result = new D2Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static (D2Scalar, D2Scalar) Variables(double constant0, double constant1)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);

        return (variable0, variable1);
    }

    public static D2Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 2)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D2Scalar[2];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);

        return variables;
    }

    public double Evaluate(double d0, double d1)
    {
        var result = Constant;

        result += D0 * d0;
        result += D1 * d1;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D2Scalar lhs, D2Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D2Scalar);
	}

	public bool Equals(D2Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D2Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 2;
    
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
		if (i >= 2)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D2Scalar Forward(double constant, double da, D2Scalar a)
    {
        var result = new D2Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        return result;
    }

    public static D2Scalar Forward(double constant, double da, double db, D2Scalar a, D2Scalar b)
    {
        var result = new D2Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        return result;
    }
    
    public static D2Scalar Forward(double constant, double da, double db, double dc, D2Scalar a, D2Scalar b, D2Scalar c)
    {
        var result = new D2Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        return result;
    }

    // neg

    public static D2Scalar operator -(D2Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D2Scalar operator +(D2Scalar lhs, D2Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D2Scalar operator +(double lhs, D2Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D2Scalar operator +(D2Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D2Scalar operator -(D2Scalar lhs, D2Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D2Scalar operator -(double lhs, D2Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D2Scalar operator -(D2Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D2Scalar operator *(D2Scalar lhs, D2Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D2Scalar operator *(double lhs, D2Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D2Scalar operator *(D2Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D2Scalar operator /(D2Scalar lhs, D2Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D2Scalar operator /(double lhs, D2Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D2Scalar operator /(D2Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D3Scalar : IScalar, IEquatable<D3Scalar>, IComparable<D3Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;

    public D3Scalar()
    {
    }

    public D3Scalar(double constant)
    {
        Constant = constant;
    }

    public D3Scalar(double constant, double d0, double d1, double d2)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
    }
    
    public D3Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
    }

    public static D3Scalar Variable0(double constant)
    {
        var result = new D3Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D3Scalar Variable1(double constant)
    {
        var result = new D3Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D3Scalar Variable2(double constant)
    {
        var result = new D3Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static (D3Scalar, D3Scalar, D3Scalar) Variables(double constant0, double constant1, double constant2)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);

        return (variable0, variable1, variable2);
    }

    public static D3Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 3)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D3Scalar[3];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2)
    {
        var result = Constant;

        result += D0 * d0;
        result += D1 * d1;
        result += D2 * d2;

        return result;
    }

    public override string ToString()
    {
        return $"{Constant}hj";
    }
    
	public static bool operator ==(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D3Scalar lhs, D3Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D3Scalar);
	}

	public bool Equals(D3Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D3Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 3;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 4);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 4)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 3)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D3Scalar Forward(double constant, double da, D3Scalar a)
    {
        var result = new D3Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        return result;
    }

    public static D3Scalar Forward(double constant, double da, double db, D3Scalar a, D3Scalar b)
    {
        var result = new D3Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        return result;
    }
    
    public static D3Scalar Forward(double constant, double da, double db, double dc, D3Scalar a, D3Scalar b, D3Scalar c)
    {
        var result = new D3Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        return result;
    }

    // neg

    public static D3Scalar operator -(D3Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D3Scalar operator +(D3Scalar lhs, D3Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D3Scalar operator +(double lhs, D3Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D3Scalar operator +(D3Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D3Scalar operator -(D3Scalar lhs, D3Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D3Scalar operator -(double lhs, D3Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D3Scalar operator -(D3Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D3Scalar operator *(D3Scalar lhs, D3Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D3Scalar operator *(double lhs, D3Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D3Scalar operator *(D3Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D3Scalar operator /(D3Scalar lhs, D3Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D3Scalar operator /(double lhs, D3Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D3Scalar operator /(D3Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D4Scalar : IScalar, IEquatable<D4Scalar>, IComparable<D4Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;

    public D4Scalar()
    {
    }

    public D4Scalar(double constant)
    {
        Constant = constant;
    }

    public D4Scalar(double constant, double d0, double d1, double d2, double d3)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
    }
    
    public D4Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
    }

    public static D4Scalar Variable0(double constant)
    {
        var result = new D4Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D4Scalar Variable1(double constant)
    {
        var result = new D4Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D4Scalar Variable2(double constant)
    {
        var result = new D4Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D4Scalar Variable3(double constant)
    {
        var result = new D4Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static (D4Scalar, D4Scalar, D4Scalar, D4Scalar) Variables(double constant0, double constant1, double constant2, double constant3)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);

        return (variable0, variable1, variable2, variable3);
    }

    public static D4Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 4)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D4Scalar[4];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3)
    {
        var result = Constant;

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
    
	public static bool operator ==(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D4Scalar lhs, D4Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D4Scalar);
	}

	public bool Equals(D4Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D4Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 4;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 5);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 5)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 4)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D4Scalar Forward(double constant, double da, D4Scalar a)
    {
        var result = new D4Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        return result;
    }

    public static D4Scalar Forward(double constant, double da, double db, D4Scalar a, D4Scalar b)
    {
        var result = new D4Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        return result;
    }
    
    public static D4Scalar Forward(double constant, double da, double db, double dc, D4Scalar a, D4Scalar b, D4Scalar c)
    {
        var result = new D4Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        return result;
    }

    // neg

    public static D4Scalar operator -(D4Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D4Scalar operator +(D4Scalar lhs, D4Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D4Scalar operator +(double lhs, D4Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D4Scalar operator +(D4Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D4Scalar operator -(D4Scalar lhs, D4Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D4Scalar operator -(double lhs, D4Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D4Scalar operator -(D4Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D4Scalar operator *(D4Scalar lhs, D4Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D4Scalar operator *(double lhs, D4Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D4Scalar operator *(D4Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D4Scalar operator /(D4Scalar lhs, D4Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D4Scalar operator /(double lhs, D4Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D4Scalar operator /(D4Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D5Scalar : IScalar, IEquatable<D5Scalar>, IComparable<D5Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;

    public D5Scalar()
    {
    }

    public D5Scalar(double constant)
    {
        Constant = constant;
    }

    public D5Scalar(double constant, double d0, double d1, double d2, double d3, double d4)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
    }
    
    public D5Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
    }

    public static D5Scalar Variable0(double constant)
    {
        var result = new D5Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D5Scalar Variable1(double constant)
    {
        var result = new D5Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D5Scalar Variable2(double constant)
    {
        var result = new D5Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D5Scalar Variable3(double constant)
    {
        var result = new D5Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D5Scalar Variable4(double constant)
    {
        var result = new D5Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static (D5Scalar, D5Scalar, D5Scalar, D5Scalar, D5Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);

        return (variable0, variable1, variable2, variable3, variable4);
    }

    public static D5Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 5)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D5Scalar[5];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4)
    {
        var result = Constant;

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
    
	public static bool operator ==(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D5Scalar lhs, D5Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D5Scalar);
	}

	public bool Equals(D5Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D5Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 5;
    
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
		if (i >= 5)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D5Scalar Forward(double constant, double da, D5Scalar a)
    {
        var result = new D5Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        return result;
    }

    public static D5Scalar Forward(double constant, double da, double db, D5Scalar a, D5Scalar b)
    {
        var result = new D5Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        return result;
    }
    
    public static D5Scalar Forward(double constant, double da, double db, double dc, D5Scalar a, D5Scalar b, D5Scalar c)
    {
        var result = new D5Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        return result;
    }

    // neg

    public static D5Scalar operator -(D5Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D5Scalar operator +(D5Scalar lhs, D5Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D5Scalar operator +(double lhs, D5Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D5Scalar operator +(D5Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D5Scalar operator -(D5Scalar lhs, D5Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D5Scalar operator -(double lhs, D5Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D5Scalar operator -(D5Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D5Scalar operator *(D5Scalar lhs, D5Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D5Scalar operator *(double lhs, D5Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D5Scalar operator *(D5Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D5Scalar operator /(D5Scalar lhs, D5Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D5Scalar operator /(double lhs, D5Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D5Scalar operator /(D5Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D6Scalar : IScalar, IEquatable<D6Scalar>, IComparable<D6Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;

    public D6Scalar()
    {
    }

    public D6Scalar(double constant)
    {
        Constant = constant;
    }

    public D6Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
    }
    
    public D6Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
    }

    public static D6Scalar Variable0(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D6Scalar Variable1(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D6Scalar Variable2(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D6Scalar Variable3(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D6Scalar Variable4(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D6Scalar Variable5(double constant)
    {
        var result = new D6Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static (D6Scalar, D6Scalar, D6Scalar, D6Scalar, D6Scalar, D6Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5)
    {
        var variable0 = Variable0(constant0);
        var variable1 = Variable1(constant1);
        var variable2 = Variable2(constant2);
        var variable3 = Variable3(constant3);
        var variable4 = Variable4(constant4);
        var variable5 = Variable5(constant5);

        return (variable0, variable1, variable2, variable3, variable4, variable5);
    }

    public static D6Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 6)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D6Scalar[6];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5)
    {
        var result = Constant;

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
    
	public static bool operator ==(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D6Scalar lhs, D6Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D6Scalar);
	}

	public bool Equals(D6Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D6Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 6;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 7);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 7)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 6)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D6Scalar Forward(double constant, double da, D6Scalar a)
    {
        var result = new D6Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        return result;
    }

    public static D6Scalar Forward(double constant, double da, double db, D6Scalar a, D6Scalar b)
    {
        var result = new D6Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        return result;
    }
    
    public static D6Scalar Forward(double constant, double da, double db, double dc, D6Scalar a, D6Scalar b, D6Scalar c)
    {
        var result = new D6Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        return result;
    }

    // neg

    public static D6Scalar operator -(D6Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D6Scalar operator +(D6Scalar lhs, D6Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D6Scalar operator +(double lhs, D6Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D6Scalar operator +(D6Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D6Scalar operator -(D6Scalar lhs, D6Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D6Scalar operator -(double lhs, D6Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D6Scalar operator -(D6Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D6Scalar operator *(D6Scalar lhs, D6Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D6Scalar operator *(double lhs, D6Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D6Scalar operator *(D6Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D6Scalar operator /(D6Scalar lhs, D6Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D6Scalar operator /(double lhs, D6Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D6Scalar operator /(D6Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D7Scalar : IScalar, IEquatable<D7Scalar>, IComparable<D7Scalar>
{
    public double Constant;
    public double D0;
    public double D1;
    public double D2;
    public double D3;
    public double D4;
    public double D5;
    public double D6;

    public D7Scalar()
    {
    }

    public D7Scalar(double constant)
    {
        Constant = constant;
    }

    public D7Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6)
    {
        Constant = constant;
        D0 = d0;
        D1 = d1;
        D2 = d2;
        D3 = d3;
        D4 = d4;
        D5 = d5;
        D6 = d6;
    }
    
    public D7Scalar(ReadOnlySpan<double> data)
    {
        Constant = data[0];
        D0 = data[1];
        D1 = data[2];
        D2 = data[3];
        D3 = data[4];
        D4 = data[5];
        D5 = data[6];
        D6 = data[7];
    }

    public static D7Scalar Variable0(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D7Scalar Variable1(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D7Scalar Variable2(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D7Scalar Variable3(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D7Scalar Variable4(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D7Scalar Variable5(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D7Scalar Variable6(double constant)
    {
        var result = new D7Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static (D7Scalar, D7Scalar, D7Scalar, D7Scalar, D7Scalar, D7Scalar, D7Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6)
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

    public static D7Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 7)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D7Scalar[7];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6)
    {
        var result = Constant;

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
    
	public static bool operator ==(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D7Scalar lhs, D7Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D7Scalar);
	}

	public bool Equals(D7Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D7Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 7;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 8);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 8)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 7)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D7Scalar Forward(double constant, double da, D7Scalar a)
    {
        var result = new D7Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        return result;
    }

    public static D7Scalar Forward(double constant, double da, double db, D7Scalar a, D7Scalar b)
    {
        var result = new D7Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        return result;
    }
    
    public static D7Scalar Forward(double constant, double da, double db, double dc, D7Scalar a, D7Scalar b, D7Scalar c)
    {
        var result = new D7Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        return result;
    }

    // neg

    public static D7Scalar operator -(D7Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D7Scalar operator +(D7Scalar lhs, D7Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D7Scalar operator +(double lhs, D7Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D7Scalar operator +(D7Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D7Scalar operator -(D7Scalar lhs, D7Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D7Scalar operator -(double lhs, D7Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D7Scalar operator -(D7Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D7Scalar operator *(D7Scalar lhs, D7Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D7Scalar operator *(double lhs, D7Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D7Scalar operator *(D7Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D7Scalar operator /(D7Scalar lhs, D7Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D7Scalar operator /(double lhs, D7Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D7Scalar operator /(D7Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D8Scalar : IScalar, IEquatable<D8Scalar>, IComparable<D8Scalar>
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

    public D8Scalar()
    {
    }

    public D8Scalar(double constant)
    {
        Constant = constant;
    }

    public D8Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7)
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
    }
    
    public D8Scalar(ReadOnlySpan<double> data)
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
    }

    public static D8Scalar Variable0(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D8Scalar Variable1(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D8Scalar Variable2(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D8Scalar Variable3(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D8Scalar Variable4(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D8Scalar Variable5(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D8Scalar Variable6(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static D8Scalar Variable7(double constant)
    {
        var result = new D8Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static (D8Scalar, D8Scalar, D8Scalar, D8Scalar, D8Scalar, D8Scalar, D8Scalar, D8Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7)
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

    public static D8Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 8)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D8Scalar[8];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);
        variables[7] = Variable7(constants[7]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7)
    {
        var result = Constant;

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
    
	public static bool operator ==(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D8Scalar lhs, D8Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D8Scalar);
	}

	public bool Equals(D8Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D8Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 8;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 9);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 9)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 8)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D8Scalar Forward(double constant, double da, D8Scalar a)
    {
        var result = new D8Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        return result;
    }

    public static D8Scalar Forward(double constant, double da, double db, D8Scalar a, D8Scalar b)
    {
        var result = new D8Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        return result;
    }
    
    public static D8Scalar Forward(double constant, double da, double db, double dc, D8Scalar a, D8Scalar b, D8Scalar c)
    {
        var result = new D8Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        return result;
    }

    // neg

    public static D8Scalar operator -(D8Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D8Scalar operator +(D8Scalar lhs, D8Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D8Scalar operator +(double lhs, D8Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D8Scalar operator +(D8Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D8Scalar operator -(D8Scalar lhs, D8Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D8Scalar operator -(double lhs, D8Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D8Scalar operator -(D8Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D8Scalar operator *(D8Scalar lhs, D8Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D8Scalar operator *(double lhs, D8Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D8Scalar operator *(D8Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D8Scalar operator /(D8Scalar lhs, D8Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D8Scalar operator /(double lhs, D8Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D8Scalar operator /(D8Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D9Scalar : IScalar, IEquatable<D9Scalar>, IComparable<D9Scalar>
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

    public D9Scalar()
    {
    }

    public D9Scalar(double constant)
    {
        Constant = constant;
    }

    public D9Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8)
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
    }
    
    public D9Scalar(ReadOnlySpan<double> data)
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
    }

    public static D9Scalar Variable0(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D9Scalar Variable1(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D9Scalar Variable2(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D9Scalar Variable3(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D9Scalar Variable4(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D9Scalar Variable5(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D9Scalar Variable6(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static D9Scalar Variable7(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static D9Scalar Variable8(double constant)
    {
        var result = new D9Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static (D9Scalar, D9Scalar, D9Scalar, D9Scalar, D9Scalar, D9Scalar, D9Scalar, D9Scalar, D9Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8)
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

    public static D9Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 9)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D9Scalar[9];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);
        variables[7] = Variable7(constants[7]);
        variables[8] = Variable8(constants[8]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8)
    {
        var result = Constant;

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
    
	public static bool operator ==(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D9Scalar lhs, D9Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D9Scalar);
	}

	public bool Equals(D9Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D9Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 9;
    
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
		if (i >= 9)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D9Scalar Forward(double constant, double da, D9Scalar a)
    {
        var result = new D9Scalar(constant);
        result.D0 = da * a.D0;
        result.D1 = da * a.D1;
        result.D2 = da * a.D2;
        result.D3 = da * a.D3;
        result.D4 = da * a.D4;
        result.D5 = da * a.D5;
        result.D6 = da * a.D6;
        result.D7 = da * a.D7;
        result.D8 = da * a.D8;
        return result;
    }

    public static D9Scalar Forward(double constant, double da, double db, D9Scalar a, D9Scalar b)
    {
        var result = new D9Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0;
        result.D1 = da * a.D1 + db * b.D1;
        result.D2 = da * a.D2 + db * b.D2;
        result.D3 = da * a.D3 + db * b.D3;
        result.D4 = da * a.D4 + db * b.D4;
        result.D5 = da * a.D5 + db * b.D5;
        result.D6 = da * a.D6 + db * b.D6;
        result.D7 = da * a.D7 + db * b.D7;
        result.D8 = da * a.D8 + db * b.D8;
        return result;
    }
    
    public static D9Scalar Forward(double constant, double da, double db, double dc, D9Scalar a, D9Scalar b, D9Scalar c)
    {
        var result = new D9Scalar(constant);
        result.D0 = da * a.D0 + db * b.D0 + dc * c.D0;
        result.D1 = da * a.D1 + db * b.D1 + dc * c.D1;
        result.D2 = da * a.D2 + db * b.D2 + dc * c.D2;
        result.D3 = da * a.D3 + db * b.D3 + dc * c.D3;
        result.D4 = da * a.D4 + db * b.D4 + dc * c.D4;
        result.D5 = da * a.D5 + db * b.D5 + dc * c.D5;
        result.D6 = da * a.D6 + db * b.D6 + dc * c.D6;
        result.D7 = da * a.D7 + db * b.D7 + dc * c.D7;
        result.D8 = da * a.D8 + db * b.D8 + dc * c.D8;
        return result;
    }

    // neg

    public static D9Scalar operator -(D9Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D9Scalar operator +(D9Scalar lhs, D9Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D9Scalar operator +(double lhs, D9Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D9Scalar operator +(D9Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D9Scalar operator -(D9Scalar lhs, D9Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D9Scalar operator -(double lhs, D9Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D9Scalar operator -(D9Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D9Scalar operator *(D9Scalar lhs, D9Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D9Scalar operator *(double lhs, D9Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D9Scalar operator *(D9Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D9Scalar operator /(D9Scalar lhs, D9Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D9Scalar operator /(double lhs, D9Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D9Scalar operator /(D9Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D10Scalar : IScalar, IEquatable<D10Scalar>, IComparable<D10Scalar>
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

    public D10Scalar()
    {
    }

    public D10Scalar(double constant)
    {
        Constant = constant;
    }

    public D10Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9)
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
    }
    
    public D10Scalar(ReadOnlySpan<double> data)
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
    }

    public static D10Scalar Variable0(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D10Scalar Variable1(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D10Scalar Variable2(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D10Scalar Variable3(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D10Scalar Variable4(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D10Scalar Variable5(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D10Scalar Variable6(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static D10Scalar Variable7(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static D10Scalar Variable8(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static D10Scalar Variable9(double constant)
    {
        var result = new D10Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static (D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar, D10Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9)
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

    public static D10Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 10)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D10Scalar[10];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);
        variables[7] = Variable7(constants[7]);
        variables[8] = Variable8(constants[8]);
        variables[9] = Variable9(constants[9]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9)
    {
        var result = Constant;

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
    
	public static bool operator ==(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D10Scalar lhs, D10Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D10Scalar);
	}

	public bool Equals(D10Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D10Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 10;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 11);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 11)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 10)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D10Scalar Forward(double constant, double da, D10Scalar a)
    {
        var result = new D10Scalar(constant);
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
        return result;
    }

    public static D10Scalar Forward(double constant, double da, double db, D10Scalar a, D10Scalar b)
    {
        var result = new D10Scalar(constant);
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
        return result;
    }
    
    public static D10Scalar Forward(double constant, double da, double db, double dc, D10Scalar a, D10Scalar b, D10Scalar c)
    {
        var result = new D10Scalar(constant);
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
        return result;
    }

    // neg

    public static D10Scalar operator -(D10Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D10Scalar operator +(D10Scalar lhs, D10Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D10Scalar operator +(double lhs, D10Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D10Scalar operator +(D10Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D10Scalar operator -(D10Scalar lhs, D10Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D10Scalar operator -(double lhs, D10Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D10Scalar operator -(D10Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D10Scalar operator *(D10Scalar lhs, D10Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D10Scalar operator *(double lhs, D10Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D10Scalar operator *(D10Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D10Scalar operator /(D10Scalar lhs, D10Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D10Scalar operator /(double lhs, D10Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D10Scalar operator /(D10Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D11Scalar : IScalar, IEquatable<D11Scalar>, IComparable<D11Scalar>
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

    public D11Scalar()
    {
    }

    public D11Scalar(double constant)
    {
        Constant = constant;
    }

    public D11Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10)
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
    }
    
    public D11Scalar(ReadOnlySpan<double> data)
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
    }

    public static D11Scalar Variable0(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D11Scalar Variable1(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D11Scalar Variable2(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D11Scalar Variable3(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D11Scalar Variable4(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D11Scalar Variable5(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D11Scalar Variable6(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static D11Scalar Variable7(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static D11Scalar Variable8(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static D11Scalar Variable9(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static D11Scalar Variable10(double constant)
    {
        var result = new D11Scalar();
        result.Constant = constant;
        result.D10 = 1;
        return result;
    }

    public static (D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar, D11Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9, double constant10)
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

    public static D11Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 11)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D11Scalar[11];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);
        variables[7] = Variable7(constants[7]);
        variables[8] = Variable8(constants[8]);
        variables[9] = Variable9(constants[9]);
        variables[10] = Variable10(constants[10]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10)
    {
        var result = Constant;

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
    
	public static bool operator ==(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D11Scalar lhs, D11Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D11Scalar);
	}

	public bool Equals(D11Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D11Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 11;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 12);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 12)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 11)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D11Scalar Forward(double constant, double da, D11Scalar a)
    {
        var result = new D11Scalar(constant);
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
        return result;
    }

    public static D11Scalar Forward(double constant, double da, double db, D11Scalar a, D11Scalar b)
    {
        var result = new D11Scalar(constant);
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
        return result;
    }
    
    public static D11Scalar Forward(double constant, double da, double db, double dc, D11Scalar a, D11Scalar b, D11Scalar c)
    {
        var result = new D11Scalar(constant);
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
        return result;
    }

    // neg

    public static D11Scalar operator -(D11Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D11Scalar operator +(D11Scalar lhs, D11Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D11Scalar operator +(double lhs, D11Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D11Scalar operator +(D11Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D11Scalar operator -(D11Scalar lhs, D11Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D11Scalar operator -(double lhs, D11Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D11Scalar operator -(D11Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D11Scalar operator *(D11Scalar lhs, D11Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D11Scalar operator *(double lhs, D11Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D11Scalar operator *(D11Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D11Scalar operator /(D11Scalar lhs, D11Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D11Scalar operator /(double lhs, D11Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D11Scalar operator /(D11Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}

[StructLayout(LayoutKind.Sequential)]
[DebuggerDisplay("{Constant}")]
public class D12Scalar : IScalar, IEquatable<D12Scalar>, IComparable<D12Scalar>
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

    public D12Scalar()
    {
    }

    public D12Scalar(double constant)
    {
        Constant = constant;
    }

    public D12Scalar(double constant, double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10, double d11)
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
    }
    
    public D12Scalar(ReadOnlySpan<double> data)
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
    }

    public static D12Scalar Variable0(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D0 = 1;
        return result;
    }

    public static D12Scalar Variable1(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D1 = 1;
        return result;
    }

    public static D12Scalar Variable2(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D2 = 1;
        return result;
    }

    public static D12Scalar Variable3(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D3 = 1;
        return result;
    }

    public static D12Scalar Variable4(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D4 = 1;
        return result;
    }

    public static D12Scalar Variable5(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D5 = 1;
        return result;
    }

    public static D12Scalar Variable6(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D6 = 1;
        return result;
    }

    public static D12Scalar Variable7(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D7 = 1;
        return result;
    }

    public static D12Scalar Variable8(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D8 = 1;
        return result;
    }

    public static D12Scalar Variable9(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D9 = 1;
        return result;
    }

    public static D12Scalar Variable10(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D10 = 1;
        return result;
    }

    public static D12Scalar Variable11(double constant)
    {
        var result = new D12Scalar();
        result.Constant = constant;
        result.D11 = 1;
        return result;
    }

    public static (D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar, D12Scalar) Variables(double constant0, double constant1, double constant2, double constant3, double constant4, double constant5, double constant6, double constant7, double constant8, double constant9, double constant10, double constant11)
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

    public static D12Scalar[] Variables(double[] constants)
    {
        if (constants.Length != 12)
            throw new ArgumentException("Invalid size.", nameof(constants));

        var variables = new D12Scalar[12];
        variables[0] = Variable0(constants[0]);
        variables[1] = Variable1(constants[1]);
        variables[2] = Variable2(constants[2]);
        variables[3] = Variable3(constants[3]);
        variables[4] = Variable4(constants[4]);
        variables[5] = Variable5(constants[5]);
        variables[6] = Variable6(constants[6]);
        variables[7] = Variable7(constants[7]);
        variables[8] = Variable8(constants[8]);
        variables[9] = Variable9(constants[9]);
        variables[10] = Variable10(constants[10]);
        variables[11] = Variable11(constants[11]);

        return variables;
    }

    public double Evaluate(double d0, double d1, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9, double d10, double d11)
    {
        var result = Constant;

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
    
	public static bool operator ==(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant == rhs.Constant;
	}

	public static bool operator !=(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant != rhs.Constant;
	}

	public static bool operator >(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;
		
		return lhs.Constant > rhs.Constant;
	}

	public static bool operator <(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant < rhs.Constant;
	}

	public static bool operator >=(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant >= rhs.Constant;
	}
	
	public static bool operator <=(D12Scalar lhs, D12Scalar rhs)
	{
		if (lhs is null || rhs is null)
			return false;

		return lhs.Constant <= rhs.Constant;
	}
    
	public override bool Equals(object obj)
	{
		return Equals(obj as D12Scalar);
	}

	public bool Equals(D12Scalar other)
	{
		return this == other;
	}
	
	public override int GetHashCode()
	{
		return Constant.GetHashCode();
	}

	public int CompareTo(D12Scalar other)
	{
		return Constant.CompareTo(other.Constant);
	}

    // Data access

    public int Size { get; } = 12;
    
    unsafe public Span<double> Data()
    {
        var ptr = Unsafe.AsPointer(ref Constant);
        return new Span<double>(ptr, 13);
    }
    
    public double[] ToArray()
    {
        return Data().ToArray();
    }
    
    public ref double Data(int i)
    {
		if (i >= 13)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref Constant, i);
    }

    public ref double D(int i)
    {
		if (i >= 12)
			throw new IndexOutOfRangeException();

		return ref Unsafe.Add(ref D0, i);
    }

    // Transformations

    public static D12Scalar Forward(double constant, double da, D12Scalar a)
    {
        var result = new D12Scalar(constant);
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
        return result;
    }

    public static D12Scalar Forward(double constant, double da, double db, D12Scalar a, D12Scalar b)
    {
        var result = new D12Scalar(constant);
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
        return result;
    }
    
    public static D12Scalar Forward(double constant, double da, double db, double dc, D12Scalar a, D12Scalar b, D12Scalar c)
    {
        var result = new D12Scalar(constant);
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
        return result;
    }

    // neg

    public static D12Scalar operator -(D12Scalar a)
    {
        return MathD.Negative(a);
    }

    // add

    public static D12Scalar operator +(D12Scalar lhs, D12Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D12Scalar operator +(double lhs, D12Scalar rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    public static D12Scalar operator +(D12Scalar lhs, double rhs)
    {
        return MathD.Add(lhs, rhs);
    }

    // sub

    public static D12Scalar operator -(D12Scalar lhs, D12Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D12Scalar operator -(double lhs, D12Scalar rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    public static D12Scalar operator -(D12Scalar lhs, double rhs)
    {
        return MathD.Subtract(lhs, rhs);
    }

    // mul

    public static D12Scalar operator *(D12Scalar lhs, D12Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D12Scalar operator *(double lhs, D12Scalar rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    public static D12Scalar operator *(D12Scalar lhs, double rhs)
    {
        return MathD.Multiply(lhs, rhs);
    }

    // div

    public static D12Scalar operator /(D12Scalar lhs, D12Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D12Scalar operator /(double lhs, D12Scalar rhs)
    {
        return MathD.Divide(lhs, rhs);
    }

    public static D12Scalar operator /(D12Scalar lhs, double rhs)
    {
        return MathD.Divide(lhs, rhs);
    }
}
