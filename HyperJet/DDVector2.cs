namespace HyperJet;

using System;
using System.Diagnostics;

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD1Vector2
{
    public readonly DD1Scalar X;
    public readonly DD1Scalar Y;

    public DD1Vector2(DD1Scalar x, DD1Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD1Vector2((DD1Scalar, DD1Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD1Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD1Vector2 operator *(double rhs, in DD1Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD1Vector2(x, y);
    }

    public static DD1Vector2 operator *(DD1Scalar rhs, in DD1Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD1Vector2(x, y);
    }

    public static DD1Vector2 operator *(DD1Vector2 rhs, in DD1Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD1Vector2 operator +(in DD1Vector2 lhs, in DD1Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD1Vector2(x, y);
    }

    public static DD1Vector2 operator -(in DD1Vector2 lhs, in DD1Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD1Vector2(x, y);
    }

    public static DD1Vector2 operator *(in DD1Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD1Vector2 operator /(in DD1Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD1Vector2(x, y);
    }

    public static DD1Vector2 operator /(in DD1Vector2 lhs, DD1Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD1Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD2Vector2
{
    public readonly DD2Scalar X;
    public readonly DD2Scalar Y;

    public DD2Vector2(DD2Scalar x, DD2Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD2Vector2((DD2Scalar, DD2Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD2Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD2Vector2 operator *(double rhs, in DD2Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD2Vector2(x, y);
    }

    public static DD2Vector2 operator *(DD2Scalar rhs, in DD2Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD2Vector2(x, y);
    }

    public static DD2Vector2 operator *(DD2Vector2 rhs, in DD2Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD2Vector2 operator +(in DD2Vector2 lhs, in DD2Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD2Vector2(x, y);
    }

    public static DD2Vector2 operator -(in DD2Vector2 lhs, in DD2Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD2Vector2(x, y);
    }

    public static DD2Vector2 operator *(in DD2Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD2Vector2 operator /(in DD2Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD2Vector2(x, y);
    }

    public static DD2Vector2 operator /(in DD2Vector2 lhs, DD2Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD2Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD3Vector2
{
    public readonly DD3Scalar X;
    public readonly DD3Scalar Y;

    public DD3Vector2(DD3Scalar x, DD3Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD3Vector2((DD3Scalar, DD3Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD3Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD3Vector2 operator *(double rhs, in DD3Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD3Vector2(x, y);
    }

    public static DD3Vector2 operator *(DD3Scalar rhs, in DD3Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD3Vector2(x, y);
    }

    public static DD3Vector2 operator *(DD3Vector2 rhs, in DD3Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD3Vector2 operator +(in DD3Vector2 lhs, in DD3Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD3Vector2(x, y);
    }

    public static DD3Vector2 operator -(in DD3Vector2 lhs, in DD3Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD3Vector2(x, y);
    }

    public static DD3Vector2 operator *(in DD3Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD3Vector2 operator /(in DD3Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD3Vector2(x, y);
    }

    public static DD3Vector2 operator /(in DD3Vector2 lhs, DD3Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD3Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD4Vector2
{
    public readonly DD4Scalar X;
    public readonly DD4Scalar Y;

    public DD4Vector2(DD4Scalar x, DD4Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD4Vector2((DD4Scalar, DD4Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD4Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD4Vector2 operator *(double rhs, in DD4Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD4Vector2(x, y);
    }

    public static DD4Vector2 operator *(DD4Scalar rhs, in DD4Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD4Vector2(x, y);
    }

    public static DD4Vector2 operator *(DD4Vector2 rhs, in DD4Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD4Vector2 operator +(in DD4Vector2 lhs, in DD4Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD4Vector2(x, y);
    }

    public static DD4Vector2 operator -(in DD4Vector2 lhs, in DD4Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD4Vector2(x, y);
    }

    public static DD4Vector2 operator *(in DD4Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD4Vector2 operator /(in DD4Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD4Vector2(x, y);
    }

    public static DD4Vector2 operator /(in DD4Vector2 lhs, DD4Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD4Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD5Vector2
{
    public readonly DD5Scalar X;
    public readonly DD5Scalar Y;

    public DD5Vector2(DD5Scalar x, DD5Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD5Vector2((DD5Scalar, DD5Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD5Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD5Vector2 operator *(double rhs, in DD5Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD5Vector2(x, y);
    }

    public static DD5Vector2 operator *(DD5Scalar rhs, in DD5Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD5Vector2(x, y);
    }

    public static DD5Vector2 operator *(DD5Vector2 rhs, in DD5Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD5Vector2 operator +(in DD5Vector2 lhs, in DD5Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD5Vector2(x, y);
    }

    public static DD5Vector2 operator -(in DD5Vector2 lhs, in DD5Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD5Vector2(x, y);
    }

    public static DD5Vector2 operator *(in DD5Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD5Vector2 operator /(in DD5Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD5Vector2(x, y);
    }

    public static DD5Vector2 operator /(in DD5Vector2 lhs, DD5Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD5Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD6Vector2
{
    public readonly DD6Scalar X;
    public readonly DD6Scalar Y;

    public DD6Vector2(DD6Scalar x, DD6Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD6Vector2((DD6Scalar, DD6Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD6Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD6Vector2 operator *(double rhs, in DD6Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD6Vector2(x, y);
    }

    public static DD6Vector2 operator *(DD6Scalar rhs, in DD6Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD6Vector2(x, y);
    }

    public static DD6Vector2 operator *(DD6Vector2 rhs, in DD6Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD6Vector2 operator +(in DD6Vector2 lhs, in DD6Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD6Vector2(x, y);
    }

    public static DD6Vector2 operator -(in DD6Vector2 lhs, in DD6Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD6Vector2(x, y);
    }

    public static DD6Vector2 operator *(in DD6Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD6Vector2 operator /(in DD6Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD6Vector2(x, y);
    }

    public static DD6Vector2 operator /(in DD6Vector2 lhs, DD6Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD6Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD7Vector2
{
    public readonly DD7Scalar X;
    public readonly DD7Scalar Y;

    public DD7Vector2(DD7Scalar x, DD7Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD7Vector2((DD7Scalar, DD7Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD7Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD7Vector2 operator *(double rhs, in DD7Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD7Vector2(x, y);
    }

    public static DD7Vector2 operator *(DD7Scalar rhs, in DD7Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD7Vector2(x, y);
    }

    public static DD7Vector2 operator *(DD7Vector2 rhs, in DD7Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD7Vector2 operator +(in DD7Vector2 lhs, in DD7Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD7Vector2(x, y);
    }

    public static DD7Vector2 operator -(in DD7Vector2 lhs, in DD7Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD7Vector2(x, y);
    }

    public static DD7Vector2 operator *(in DD7Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD7Vector2 operator /(in DD7Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD7Vector2(x, y);
    }

    public static DD7Vector2 operator /(in DD7Vector2 lhs, DD7Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD7Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD8Vector2
{
    public readonly DD8Scalar X;
    public readonly DD8Scalar Y;

    public DD8Vector2(DD8Scalar x, DD8Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD8Vector2((DD8Scalar, DD8Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD8Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD8Vector2 operator *(double rhs, in DD8Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD8Vector2(x, y);
    }

    public static DD8Vector2 operator *(DD8Scalar rhs, in DD8Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD8Vector2(x, y);
    }

    public static DD8Vector2 operator *(DD8Vector2 rhs, in DD8Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD8Vector2 operator +(in DD8Vector2 lhs, in DD8Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD8Vector2(x, y);
    }

    public static DD8Vector2 operator -(in DD8Vector2 lhs, in DD8Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD8Vector2(x, y);
    }

    public static DD8Vector2 operator *(in DD8Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD8Vector2 operator /(in DD8Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD8Vector2(x, y);
    }

    public static DD8Vector2 operator /(in DD8Vector2 lhs, DD8Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD8Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD9Vector2
{
    public readonly DD9Scalar X;
    public readonly DD9Scalar Y;

    public DD9Vector2(DD9Scalar x, DD9Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD9Vector2((DD9Scalar, DD9Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD9Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD9Vector2 operator *(double rhs, in DD9Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD9Vector2(x, y);
    }

    public static DD9Vector2 operator *(DD9Scalar rhs, in DD9Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD9Vector2(x, y);
    }

    public static DD9Vector2 operator *(DD9Vector2 rhs, in DD9Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD9Vector2 operator +(in DD9Vector2 lhs, in DD9Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD9Vector2(x, y);
    }

    public static DD9Vector2 operator -(in DD9Vector2 lhs, in DD9Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD9Vector2(x, y);
    }

    public static DD9Vector2 operator *(in DD9Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD9Vector2 operator /(in DD9Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD9Vector2(x, y);
    }

    public static DD9Vector2 operator /(in DD9Vector2 lhs, DD9Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD9Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD10Vector2
{
    public readonly DD10Scalar X;
    public readonly DD10Scalar Y;

    public DD10Vector2(DD10Scalar x, DD10Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD10Vector2((DD10Scalar, DD10Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD10Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD10Vector2 operator *(double rhs, in DD10Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD10Vector2(x, y);
    }

    public static DD10Vector2 operator *(DD10Scalar rhs, in DD10Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD10Vector2(x, y);
    }

    public static DD10Vector2 operator *(DD10Vector2 rhs, in DD10Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD10Vector2 operator +(in DD10Vector2 lhs, in DD10Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD10Vector2(x, y);
    }

    public static DD10Vector2 operator -(in DD10Vector2 lhs, in DD10Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD10Vector2(x, y);
    }

    public static DD10Vector2 operator *(in DD10Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD10Vector2 operator /(in DD10Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD10Vector2(x, y);
    }

    public static DD10Vector2 operator /(in DD10Vector2 lhs, DD10Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD10Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD11Vector2
{
    public readonly DD11Scalar X;
    public readonly DD11Scalar Y;

    public DD11Vector2(DD11Scalar x, DD11Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD11Vector2((DD11Scalar, DD11Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD11Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD11Vector2 operator *(double rhs, in DD11Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD11Vector2(x, y);
    }

    public static DD11Vector2 operator *(DD11Scalar rhs, in DD11Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD11Vector2(x, y);
    }

    public static DD11Vector2 operator *(DD11Vector2 rhs, in DD11Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD11Vector2 operator +(in DD11Vector2 lhs, in DD11Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD11Vector2(x, y);
    }

    public static DD11Vector2 operator -(in DD11Vector2 lhs, in DD11Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD11Vector2(x, y);
    }

    public static DD11Vector2 operator *(in DD11Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD11Vector2 operator /(in DD11Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD11Vector2(x, y);
    }

    public static DD11Vector2 operator /(in DD11Vector2 lhs, DD11Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD11Vector2(x, y);
    }
}

[DebuggerDisplay("[{X}, {Y}]")]
public struct DD12Vector2
{
    public readonly DD12Scalar X;
    public readonly DD12Scalar Y;

    public DD12Vector2(DD12Scalar x, DD12Scalar y)
    {
        X = x ?? throw new ArgumentNullException(nameof(x));
        Y = y ?? throw new ArgumentNullException(nameof(y));
    }

    public DD12Vector2((DD12Scalar, DD12Scalar) xy)
    {
        var (x, y) = xy;

        X = x ?? throw new NullReferenceException(nameof(x));
        Y = y ?? throw new NullReferenceException(nameof(y));
    }

    // Data access

    public DD12Scalar this[int index] => index switch
    {
        0 => X,
        1 => Y,
        _ => throw new IndexOutOfRangeException()
    };

    public static DD12Vector2 operator *(double rhs, in DD12Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD12Vector2(x, y);
    }

    public static DD12Vector2 operator *(DD12Scalar rhs, in DD12Vector2 lhs)
    {
        var x = lhs.X * rhs;
        var y = lhs.Y * rhs;

        return new DD12Vector2(x, y);
    }

    public static DD12Vector2 operator *(DD12Vector2 rhs, in DD12Scalar lhs)
    {
        return lhs * rhs;
    }

    public static DD12Vector2 operator +(in DD12Vector2 lhs, in DD12Vector2 rhs)
    {
        var x = lhs.X + rhs.X;
        var y = lhs.Y + rhs.Y;

        return new DD12Vector2(x, y);
    }

    public static DD12Vector2 operator -(in DD12Vector2 lhs, in DD12Vector2 rhs)
    {
        var x = lhs.X - rhs.X;
        var y = lhs.Y - rhs.Y;

        return new DD12Vector2(x, y);
    }

    public static DD12Vector2 operator *(in DD12Vector2 lhs, double rhs)
    {
        return rhs * lhs;
    }

    public static DD12Vector2 operator /(in DD12Vector2 lhs, double rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD12Vector2(x, y);
    }

    public static DD12Vector2 operator /(in DD12Vector2 lhs, DD12Scalar rhs)
    {
        var x = lhs.X / rhs;
        var y = lhs.Y / rhs;

        return new DD12Vector2(x, y);
    }
}
