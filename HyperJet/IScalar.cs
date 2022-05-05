using System;

namespace HyperJet;

public interface IScalar
{
    int Size { get; }

    Span<double> Data();
}
