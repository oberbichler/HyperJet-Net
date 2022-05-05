namespace HyperJet;

using System;
using System.Diagnostics;

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D1Vector3
{
    public readonly D1Scalar X;
    public readonly D1Scalar Y;
    public readonly D1Scalar Z;

    public D1Vector3(D1Scalar x, D1Scalar y, D1Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D1Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D1Vector3 operator *(double rhs, in D1Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D1Vector3(x, y, z);
    }

    public static D1Vector3 operator *(D1Scalar rhs, in D1Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D1Vector3(x, y, z);
    }

    public static D1Vector3 operator *(D1Vector3 rhs, in D1Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D1Vector3 operator +(in D1Vector3 lhs, in D1Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D1Vector3(x, y, z);
    }

    public static D1Vector3 operator -(in D1Vector3 lhs, in D1Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D1Vector3(x, y, z);
    }

    public static D1Vector3 operator *(in D1Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D1Vector3 operator /(in D1Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D1Vector3(x, y, z);
    }

    public static D1Vector3 operator /(in D1Vector3 lhs, D1Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D1Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D2Vector3
{
    public readonly D2Scalar X;
    public readonly D2Scalar Y;
    public readonly D2Scalar Z;

    public D2Vector3(D2Scalar x, D2Scalar y, D2Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D2Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D2Vector3 operator *(double rhs, in D2Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D2Vector3(x, y, z);
    }

    public static D2Vector3 operator *(D2Scalar rhs, in D2Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D2Vector3(x, y, z);
    }

    public static D2Vector3 operator *(D2Vector3 rhs, in D2Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D2Vector3 operator +(in D2Vector3 lhs, in D2Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D2Vector3(x, y, z);
    }

    public static D2Vector3 operator -(in D2Vector3 lhs, in D2Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D2Vector3(x, y, z);
    }

    public static D2Vector3 operator *(in D2Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D2Vector3 operator /(in D2Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D2Vector3(x, y, z);
    }

    public static D2Vector3 operator /(in D2Vector3 lhs, D2Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D2Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D3Vector3
{
    public readonly D3Scalar X;
    public readonly D3Scalar Y;
    public readonly D3Scalar Z;

    public D3Vector3(D3Scalar x, D3Scalar y, D3Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D3Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D3Vector3 operator *(double rhs, in D3Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D3Vector3(x, y, z);
    }

    public static D3Vector3 operator *(D3Scalar rhs, in D3Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D3Vector3(x, y, z);
    }

    public static D3Vector3 operator *(D3Vector3 rhs, in D3Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D3Vector3 operator +(in D3Vector3 lhs, in D3Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D3Vector3(x, y, z);
    }

    public static D3Vector3 operator -(in D3Vector3 lhs, in D3Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D3Vector3(x, y, z);
    }

    public static D3Vector3 operator *(in D3Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D3Vector3 operator /(in D3Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D3Vector3(x, y, z);
    }

    public static D3Vector3 operator /(in D3Vector3 lhs, D3Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D3Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D4Vector3
{
    public readonly D4Scalar X;
    public readonly D4Scalar Y;
    public readonly D4Scalar Z;

    public D4Vector3(D4Scalar x, D4Scalar y, D4Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D4Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D4Vector3 operator *(double rhs, in D4Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D4Vector3(x, y, z);
    }

    public static D4Vector3 operator *(D4Scalar rhs, in D4Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D4Vector3(x, y, z);
    }

    public static D4Vector3 operator *(D4Vector3 rhs, in D4Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D4Vector3 operator +(in D4Vector3 lhs, in D4Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D4Vector3(x, y, z);
    }

    public static D4Vector3 operator -(in D4Vector3 lhs, in D4Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D4Vector3(x, y, z);
    }

    public static D4Vector3 operator *(in D4Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D4Vector3 operator /(in D4Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D4Vector3(x, y, z);
    }

    public static D4Vector3 operator /(in D4Vector3 lhs, D4Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D4Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D5Vector3
{
    public readonly D5Scalar X;
    public readonly D5Scalar Y;
    public readonly D5Scalar Z;

    public D5Vector3(D5Scalar x, D5Scalar y, D5Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D5Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D5Vector3 operator *(double rhs, in D5Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D5Vector3(x, y, z);
    }

    public static D5Vector3 operator *(D5Scalar rhs, in D5Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D5Vector3(x, y, z);
    }

    public static D5Vector3 operator *(D5Vector3 rhs, in D5Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D5Vector3 operator +(in D5Vector3 lhs, in D5Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D5Vector3(x, y, z);
    }

    public static D5Vector3 operator -(in D5Vector3 lhs, in D5Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D5Vector3(x, y, z);
    }

    public static D5Vector3 operator *(in D5Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D5Vector3 operator /(in D5Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D5Vector3(x, y, z);
    }

    public static D5Vector3 operator /(in D5Vector3 lhs, D5Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D5Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D6Vector3
{
    public readonly D6Scalar X;
    public readonly D6Scalar Y;
    public readonly D6Scalar Z;

    public D6Vector3(D6Scalar x, D6Scalar y, D6Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D6Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D6Vector3 operator *(double rhs, in D6Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D6Vector3(x, y, z);
    }

    public static D6Vector3 operator *(D6Scalar rhs, in D6Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D6Vector3(x, y, z);
    }

    public static D6Vector3 operator *(D6Vector3 rhs, in D6Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D6Vector3 operator +(in D6Vector3 lhs, in D6Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D6Vector3(x, y, z);
    }

    public static D6Vector3 operator -(in D6Vector3 lhs, in D6Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D6Vector3(x, y, z);
    }

    public static D6Vector3 operator *(in D6Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D6Vector3 operator /(in D6Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D6Vector3(x, y, z);
    }

    public static D6Vector3 operator /(in D6Vector3 lhs, D6Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D6Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D7Vector3
{
    public readonly D7Scalar X;
    public readonly D7Scalar Y;
    public readonly D7Scalar Z;

    public D7Vector3(D7Scalar x, D7Scalar y, D7Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D7Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D7Vector3 operator *(double rhs, in D7Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D7Vector3(x, y, z);
    }

    public static D7Vector3 operator *(D7Scalar rhs, in D7Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D7Vector3(x, y, z);
    }

    public static D7Vector3 operator *(D7Vector3 rhs, in D7Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D7Vector3 operator +(in D7Vector3 lhs, in D7Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D7Vector3(x, y, z);
    }

    public static D7Vector3 operator -(in D7Vector3 lhs, in D7Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D7Vector3(x, y, z);
    }

    public static D7Vector3 operator *(in D7Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D7Vector3 operator /(in D7Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D7Vector3(x, y, z);
    }

    public static D7Vector3 operator /(in D7Vector3 lhs, D7Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D7Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D8Vector3
{
    public readonly D8Scalar X;
    public readonly D8Scalar Y;
    public readonly D8Scalar Z;

    public D8Vector3(D8Scalar x, D8Scalar y, D8Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D8Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D8Vector3 operator *(double rhs, in D8Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D8Vector3(x, y, z);
    }

    public static D8Vector3 operator *(D8Scalar rhs, in D8Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D8Vector3(x, y, z);
    }

    public static D8Vector3 operator *(D8Vector3 rhs, in D8Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D8Vector3 operator +(in D8Vector3 lhs, in D8Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D8Vector3(x, y, z);
    }

    public static D8Vector3 operator -(in D8Vector3 lhs, in D8Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D8Vector3(x, y, z);
    }

    public static D8Vector3 operator *(in D8Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D8Vector3 operator /(in D8Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D8Vector3(x, y, z);
    }

    public static D8Vector3 operator /(in D8Vector3 lhs, D8Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D8Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D9Vector3
{
    public readonly D9Scalar X;
    public readonly D9Scalar Y;
    public readonly D9Scalar Z;

    public D9Vector3(D9Scalar x, D9Scalar y, D9Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D9Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D9Vector3 operator *(double rhs, in D9Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D9Vector3(x, y, z);
    }

    public static D9Vector3 operator *(D9Scalar rhs, in D9Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D9Vector3(x, y, z);
    }

    public static D9Vector3 operator *(D9Vector3 rhs, in D9Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D9Vector3 operator +(in D9Vector3 lhs, in D9Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D9Vector3(x, y, z);
    }

    public static D9Vector3 operator -(in D9Vector3 lhs, in D9Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D9Vector3(x, y, z);
    }

    public static D9Vector3 operator *(in D9Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D9Vector3 operator /(in D9Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D9Vector3(x, y, z);
    }

    public static D9Vector3 operator /(in D9Vector3 lhs, D9Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D9Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D10Vector3
{
    public readonly D10Scalar X;
    public readonly D10Scalar Y;
    public readonly D10Scalar Z;

    public D10Vector3(D10Scalar x, D10Scalar y, D10Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D10Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D10Vector3 operator *(double rhs, in D10Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D10Vector3(x, y, z);
    }

    public static D10Vector3 operator *(D10Scalar rhs, in D10Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D10Vector3(x, y, z);
    }

    public static D10Vector3 operator *(D10Vector3 rhs, in D10Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D10Vector3 operator +(in D10Vector3 lhs, in D10Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D10Vector3(x, y, z);
    }

    public static D10Vector3 operator -(in D10Vector3 lhs, in D10Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D10Vector3(x, y, z);
    }

    public static D10Vector3 operator *(in D10Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D10Vector3 operator /(in D10Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D10Vector3(x, y, z);
    }

    public static D10Vector3 operator /(in D10Vector3 lhs, D10Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D10Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D11Vector3
{
    public readonly D11Scalar X;
    public readonly D11Scalar Y;
    public readonly D11Scalar Z;

    public D11Vector3(D11Scalar x, D11Scalar y, D11Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D11Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D11Vector3 operator *(double rhs, in D11Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D11Vector3(x, y, z);
    }

    public static D11Vector3 operator *(D11Scalar rhs, in D11Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D11Vector3(x, y, z);
    }

    public static D11Vector3 operator *(D11Vector3 rhs, in D11Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D11Vector3 operator +(in D11Vector3 lhs, in D11Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D11Vector3(x, y, z);
    }

    public static D11Vector3 operator -(in D11Vector3 lhs, in D11Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D11Vector3(x, y, z);
    }

    public static D11Vector3 operator *(in D11Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D11Vector3 operator /(in D11Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D11Vector3(x, y, z);
    }

    public static D11Vector3 operator /(in D11Vector3 lhs, D11Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D11Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct D12Vector3
{
    public readonly D12Scalar X;
    public readonly D12Scalar Y;
    public readonly D12Scalar Z;

    public D12Vector3(D12Scalar x, D12Scalar y, D12Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    // Data access

    public D12Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static D12Vector3 operator *(double rhs, in D12Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D12Vector3(x, y, z);
    }

    public static D12Vector3 operator *(D12Scalar rhs, in D12Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new D12Vector3(x, y, z);
    }

    public static D12Vector3 operator *(D12Vector3 rhs, in D12Scalar lhs)
    {
        return lhs * rhs;
    }

    public static D12Vector3 operator +(in D12Vector3 lhs, in D12Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new D12Vector3(x, y, z);
    }

    public static D12Vector3 operator -(in D12Vector3 lhs, in D12Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new D12Vector3(x, y, z);
    }

    public static D12Vector3 operator *(in D12Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static D12Vector3 operator /(in D12Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D12Vector3(x, y, z);
    }

    public static D12Vector3 operator /(in D12Vector3 lhs, D12Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new D12Vector3(x, y, z);
    }
}
