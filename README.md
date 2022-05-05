![HyperJet Logo](https://github.com/oberbichler/HyperJet-Net/blob/f9341794ae9fc497e86c6234abcfeadc27605502/docs/HyperJet.png)

<p align="center"><b>HyperJet.NET — Algorithmic differentiation with multivariate hyper-dual numbers in C#</b></p>

---

[![.NET](https://github.com/oberbichler/HyperJet-Net/actions/workflows/ci.yml/badge.svg)](https://github.com/oberbichler/HyperJet-Net/actions/workflows/ci.yml) ![Nuget](https://img.shields.io/nuget/v/HyperJet)

## Examples

HyperJet contains data types for multivariate hyper-dual numbers with fixed dimension. `D2Scalar` e.g., can be used to compute gradients of functions with two parameters.

```csharp
using static System.Console;

using HyperJet;

// Import standard math (Pow, Sqrt, ...)
using static HyperJet.MathD;

// Initialize variables
var (a, b) = D2Scalar.Variables(3, 4);

// Compute value
var c = Sqrt(Pow(a, 2) + Pow(b, 2));

// Get derivatives
WriteLine($"dc/da = {c.D0}");
WriteLine($"dc/db = {c.D1}");
```

[Open in .NET Fiddle](https://dotnetfiddle.net/Of9xMJ)

Using `DD5Scalar`, gradients and hessians of functions with 5 parameters can be computed. `DD6Vector3` enables vector operations.

```csharp
using static System.Console;

using HyperJet;

// Import standard math (Pow, Sqrt, ...)
using static HyperJet.MathD;

// Import linear algebra (Norm, Dot, ...)
using static HyperJet.LinearAlgebraD;

// Initialize variables
var (x1, y1, z1, x2, y2, z2) = DD6Scalar.Variables(0, 0, 2, 3, 4, 2);

var p1 = new DD6Vector3(x1, y1, z1);
var p2 = new DD6Vector3(x2, y2, z2);

// Compute value
var l = Norm(p2 - p1);

// Get derivatives
WriteLine($"dl/dx1 = {l.D0}");
WriteLine($"dl/dy1 = {l.D1}");
WriteLine($"dl/dz1 = {l.D2}");
WriteLine($"dl/dx2 = {l.D3}");
WriteLine($"dl/dy2 = {l.D4}");
WriteLine($"dl/dz2 = {l.D5}");

// Get hessian
WriteLine($"d2l/dx1dx1 = {l.D0D0}");
WriteLine($"d2l/dx1dy1 = {l.D0D1}");
WriteLine($"d2l/dx1dz1 = {l.D0D2}");
//...
```

[Open in .NET Fiddle](https://dotnetfiddle.net/UjToUB)
