namespace HyperJet;

using System;
using System.Diagnostics;

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD1Vector3
{
    public readonly DD1Scalar X;
    public readonly DD1Scalar Y;
    public readonly DD1Scalar Z;

    public DD1Vector3(DD1Scalar x, DD1Scalar y, DD1Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD1Vector3((DD1Scalar, DD1Scalar, DD1Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD1Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD1Vector3 operator *(double rhs, in DD1Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD1Vector3(x, y, z);
    }

    public static DD1Vector3 operator *(DD1Scalar rhs, in DD1Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD1Vector3(x, y, z);
    }

    public static DD1Vector3 operator *(DD1Vector3 rhs, in DD1Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD1Vector3 operator +(in DD1Vector3 lhs, in DD1Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD1Vector3(x, y, z);
    }

    public static DD1Vector3 operator -(in DD1Vector3 lhs, in DD1Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD1Vector3(x, y, z);
    }

    public static DD1Vector3 operator *(in DD1Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD1Vector3 operator /(in DD1Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD1Vector3(x, y, z);
    }

    public static DD1Vector3 operator /(in DD1Vector3 lhs, DD1Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD1Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD2Vector3
{
    public readonly DD2Scalar X;
    public readonly DD2Scalar Y;
    public readonly DD2Scalar Z;

    public DD2Vector3(DD2Scalar x, DD2Scalar y, DD2Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD2Vector3((DD2Scalar, DD2Scalar, DD2Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD2Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD2Vector3 operator *(double rhs, in DD2Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD2Vector3(x, y, z);
    }

    public static DD2Vector3 operator *(DD2Scalar rhs, in DD2Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD2Vector3(x, y, z);
    }

    public static DD2Vector3 operator *(DD2Vector3 rhs, in DD2Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD2Vector3 operator +(in DD2Vector3 lhs, in DD2Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD2Vector3(x, y, z);
    }

    public static DD2Vector3 operator -(in DD2Vector3 lhs, in DD2Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD2Vector3(x, y, z);
    }

    public static DD2Vector3 operator *(in DD2Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD2Vector3 operator /(in DD2Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD2Vector3(x, y, z);
    }

    public static DD2Vector3 operator /(in DD2Vector3 lhs, DD2Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD2Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD3Vector3
{
    public readonly DD3Scalar X;
    public readonly DD3Scalar Y;
    public readonly DD3Scalar Z;

    public DD3Vector3(DD3Scalar x, DD3Scalar y, DD3Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD3Vector3((DD3Scalar, DD3Scalar, DD3Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD3Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD3Vector3 operator *(double rhs, in DD3Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD3Vector3(x, y, z);
    }

    public static DD3Vector3 operator *(DD3Scalar rhs, in DD3Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD3Vector3(x, y, z);
    }

    public static DD3Vector3 operator *(DD3Vector3 rhs, in DD3Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD3Vector3 operator +(in DD3Vector3 lhs, in DD3Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD3Vector3(x, y, z);
    }

    public static DD3Vector3 operator -(in DD3Vector3 lhs, in DD3Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD3Vector3(x, y, z);
    }

    public static DD3Vector3 operator *(in DD3Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD3Vector3 operator /(in DD3Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD3Vector3(x, y, z);
    }

    public static DD3Vector3 operator /(in DD3Vector3 lhs, DD3Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD3Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD4Vector3
{
    public readonly DD4Scalar X;
    public readonly DD4Scalar Y;
    public readonly DD4Scalar Z;

    public DD4Vector3(DD4Scalar x, DD4Scalar y, DD4Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD4Vector3((DD4Scalar, DD4Scalar, DD4Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD4Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD4Vector3 operator *(double rhs, in DD4Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD4Vector3(x, y, z);
    }

    public static DD4Vector3 operator *(DD4Scalar rhs, in DD4Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD4Vector3(x, y, z);
    }

    public static DD4Vector3 operator *(DD4Vector3 rhs, in DD4Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD4Vector3 operator +(in DD4Vector3 lhs, in DD4Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD4Vector3(x, y, z);
    }

    public static DD4Vector3 operator -(in DD4Vector3 lhs, in DD4Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD4Vector3(x, y, z);
    }

    public static DD4Vector3 operator *(in DD4Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD4Vector3 operator /(in DD4Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD4Vector3(x, y, z);
    }

    public static DD4Vector3 operator /(in DD4Vector3 lhs, DD4Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD4Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD5Vector3
{
    public readonly DD5Scalar X;
    public readonly DD5Scalar Y;
    public readonly DD5Scalar Z;

    public DD5Vector3(DD5Scalar x, DD5Scalar y, DD5Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD5Vector3((DD5Scalar, DD5Scalar, DD5Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD5Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD5Vector3 operator *(double rhs, in DD5Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD5Vector3(x, y, z);
    }

    public static DD5Vector3 operator *(DD5Scalar rhs, in DD5Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD5Vector3(x, y, z);
    }

    public static DD5Vector3 operator *(DD5Vector3 rhs, in DD5Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD5Vector3 operator +(in DD5Vector3 lhs, in DD5Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD5Vector3(x, y, z);
    }

    public static DD5Vector3 operator -(in DD5Vector3 lhs, in DD5Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD5Vector3(x, y, z);
    }

    public static DD5Vector3 operator *(in DD5Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD5Vector3 operator /(in DD5Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD5Vector3(x, y, z);
    }

    public static DD5Vector3 operator /(in DD5Vector3 lhs, DD5Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD5Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD6Vector3
{
    public readonly DD6Scalar X;
    public readonly DD6Scalar Y;
    public readonly DD6Scalar Z;

    public DD6Vector3(DD6Scalar x, DD6Scalar y, DD6Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD6Vector3((DD6Scalar, DD6Scalar, DD6Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD6Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD6Vector3 operator *(double rhs, in DD6Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD6Vector3(x, y, z);
    }

    public static DD6Vector3 operator *(DD6Scalar rhs, in DD6Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD6Vector3(x, y, z);
    }

    public static DD6Vector3 operator *(DD6Vector3 rhs, in DD6Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD6Vector3 operator +(in DD6Vector3 lhs, in DD6Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD6Vector3(x, y, z);
    }

    public static DD6Vector3 operator -(in DD6Vector3 lhs, in DD6Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD6Vector3(x, y, z);
    }

    public static DD6Vector3 operator *(in DD6Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD6Vector3 operator /(in DD6Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD6Vector3(x, y, z);
    }

    public static DD6Vector3 operator /(in DD6Vector3 lhs, DD6Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD6Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD7Vector3
{
    public readonly DD7Scalar X;
    public readonly DD7Scalar Y;
    public readonly DD7Scalar Z;

    public DD7Vector3(DD7Scalar x, DD7Scalar y, DD7Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD7Vector3((DD7Scalar, DD7Scalar, DD7Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD7Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD7Vector3 operator *(double rhs, in DD7Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD7Vector3(x, y, z);
    }

    public static DD7Vector3 operator *(DD7Scalar rhs, in DD7Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD7Vector3(x, y, z);
    }

    public static DD7Vector3 operator *(DD7Vector3 rhs, in DD7Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD7Vector3 operator +(in DD7Vector3 lhs, in DD7Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD7Vector3(x, y, z);
    }

    public static DD7Vector3 operator -(in DD7Vector3 lhs, in DD7Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD7Vector3(x, y, z);
    }

    public static DD7Vector3 operator *(in DD7Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD7Vector3 operator /(in DD7Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD7Vector3(x, y, z);
    }

    public static DD7Vector3 operator /(in DD7Vector3 lhs, DD7Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD7Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD8Vector3
{
    public readonly DD8Scalar X;
    public readonly DD8Scalar Y;
    public readonly DD8Scalar Z;

    public DD8Vector3(DD8Scalar x, DD8Scalar y, DD8Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD8Vector3((DD8Scalar, DD8Scalar, DD8Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD8Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD8Vector3 operator *(double rhs, in DD8Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD8Vector3(x, y, z);
    }

    public static DD8Vector3 operator *(DD8Scalar rhs, in DD8Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD8Vector3(x, y, z);
    }

    public static DD8Vector3 operator *(DD8Vector3 rhs, in DD8Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD8Vector3 operator +(in DD8Vector3 lhs, in DD8Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD8Vector3(x, y, z);
    }

    public static DD8Vector3 operator -(in DD8Vector3 lhs, in DD8Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD8Vector3(x, y, z);
    }

    public static DD8Vector3 operator *(in DD8Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD8Vector3 operator /(in DD8Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD8Vector3(x, y, z);
    }

    public static DD8Vector3 operator /(in DD8Vector3 lhs, DD8Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD8Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD9Vector3
{
    public readonly DD9Scalar X;
    public readonly DD9Scalar Y;
    public readonly DD9Scalar Z;

    public DD9Vector3(DD9Scalar x, DD9Scalar y, DD9Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD9Vector3((DD9Scalar, DD9Scalar, DD9Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD9Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD9Vector3 operator *(double rhs, in DD9Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD9Vector3(x, y, z);
    }

    public static DD9Vector3 operator *(DD9Scalar rhs, in DD9Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD9Vector3(x, y, z);
    }

    public static DD9Vector3 operator *(DD9Vector3 rhs, in DD9Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD9Vector3 operator +(in DD9Vector3 lhs, in DD9Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD9Vector3(x, y, z);
    }

    public static DD9Vector3 operator -(in DD9Vector3 lhs, in DD9Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD9Vector3(x, y, z);
    }

    public static DD9Vector3 operator *(in DD9Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD9Vector3 operator /(in DD9Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD9Vector3(x, y, z);
    }

    public static DD9Vector3 operator /(in DD9Vector3 lhs, DD9Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD9Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD10Vector3
{
    public readonly DD10Scalar X;
    public readonly DD10Scalar Y;
    public readonly DD10Scalar Z;

    public DD10Vector3(DD10Scalar x, DD10Scalar y, DD10Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD10Vector3((DD10Scalar, DD10Scalar, DD10Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD10Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD10Vector3 operator *(double rhs, in DD10Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD10Vector3(x, y, z);
    }

    public static DD10Vector3 operator *(DD10Scalar rhs, in DD10Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD10Vector3(x, y, z);
    }

    public static DD10Vector3 operator *(DD10Vector3 rhs, in DD10Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD10Vector3 operator +(in DD10Vector3 lhs, in DD10Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD10Vector3(x, y, z);
    }

    public static DD10Vector3 operator -(in DD10Vector3 lhs, in DD10Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD10Vector3(x, y, z);
    }

    public static DD10Vector3 operator *(in DD10Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD10Vector3 operator /(in DD10Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD10Vector3(x, y, z);
    }

    public static DD10Vector3 operator /(in DD10Vector3 lhs, DD10Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD10Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD11Vector3
{
    public readonly DD11Scalar X;
    public readonly DD11Scalar Y;
    public readonly DD11Scalar Z;

    public DD11Vector3(DD11Scalar x, DD11Scalar y, DD11Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD11Vector3((DD11Scalar, DD11Scalar, DD11Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD11Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD11Vector3 operator *(double rhs, in DD11Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD11Vector3(x, y, z);
    }

    public static DD11Vector3 operator *(DD11Scalar rhs, in DD11Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD11Vector3(x, y, z);
    }

    public static DD11Vector3 operator *(DD11Vector3 rhs, in DD11Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD11Vector3 operator +(in DD11Vector3 lhs, in DD11Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD11Vector3(x, y, z);
    }

    public static DD11Vector3 operator -(in DD11Vector3 lhs, in DD11Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD11Vector3(x, y, z);
    }

    public static DD11Vector3 operator *(in DD11Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD11Vector3 operator /(in DD11Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD11Vector3(x, y, z);
    }

    public static DD11Vector3 operator /(in DD11Vector3 lhs, DD11Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD11Vector3(x, y, z);
    }
}

[DebuggerDisplay("[{X}, {Y}, {Z}]")]
public struct DD12Vector3
{
    public readonly DD12Scalar X;
    public readonly DD12Scalar Y;
    public readonly DD12Scalar Z;

    public DD12Vector3(DD12Scalar x, DD12Scalar y, DD12Scalar z)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
        Z = z ?? throw new ArgumentNullException(nameof(z));
    }

    public DD12Vector3((DD12Scalar, DD12Scalar, DD12Scalar) xyz)
    {
        var (x, y, z) = xyz;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
        Z = z ?? throw new NullReferenceException(nameof(z));
    }

    // Data access

    public DD12Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        2 => Z,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD12Vector3 operator *(double rhs, in DD12Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD12Vector3(x, y, z);
    }

    public static DD12Vector3 operator *(DD12Scalar rhs, in DD12Vector3 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;
        var z = lhs.Z * rhs;

        return new DD12Vector3(x, y, z);
    }

    public static DD12Vector3 operator *(DD12Vector3 rhs, in DD12Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD12Vector3 operator +(in DD12Vector3 lhs, in DD12Vector3 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;
        var z = lhs.Z + rhs.Z;

        return new DD12Vector3(x, y, z);
    }

    public static DD12Vector3 operator -(in DD12Vector3 lhs, in DD12Vector3 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;
        var z = lhs.Z - rhs.Z;

        return new DD12Vector3(x, y, z);
    }

    public static DD12Vector3 operator *(in DD12Vector3 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD12Vector3 operator /(in DD12Vector3 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD12Vector3(x, y, z);
    }

    public static DD12Vector3 operator /(in DD12Vector3 lhs, DD12Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;
        var z = lhs.Z / rhs;

        return new DD12Vector3(x, y, z);
    }
}
