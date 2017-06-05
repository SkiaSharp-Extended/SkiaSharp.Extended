# SkiaSharp.Extended

[![SkiaSharp](https://img.shields.io/nuget/vpre/SkiaSharp.Extended.svg?maxAge=2592000)](https://www.nuget.org/packages/SkiaSharp.Extended)

**SkiaSharp.Extended** is a collection some cool functions that may be 
useful to some apps.

There are a few helper methods that can be used to create geometric 
shapes in the `SKGeometry` type:

 - `CreateSectorPath` - 
   creates a path with the shape of sector/section of a doughnut/pie 
   chart
 - `CreatePiePath` - 
   creates a path with the shape of a doughnut/pie chart
 - `CreateSquarePath` - 
   creates a path with the shape of a square
 - `CreateRectanglePath` - 
   creates a path with the shape of a rectangle
 - `CreateTrianglePath` - 
   creates a path with the shape of a triangle
 - `CreateRegularPolygonPath` - 
   creates a path with the shape of some regular polygon
 - `CreateRegularStarPath` - 
   creates a path with the shape of a square

Some of these shapes can also be draw directly on a `SKCanvas` 
using the extensions methods:

```csharp
SKCanvas canvas = ...
canvas.DrawStar(
    100, 100, // x, y
    100,      // outer radius
    50,       // inner radius
    5);       // points
```

## Building

Building SkiaSharp.Extended just requires that [.NET Core][netcore] be 
installed. Then, either open the solution `SkiaSharp.Extended.sln` or
run the build script:

Mac/Linux:

    $ ./build.sh

Windows:

    > .\build.ps1

## License

    MIT License

    Copyright (c) 2017 Matthew Leibowitz

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.

[netcore]: https://www.microsoft.com/net/core