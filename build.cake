var target = Argument("target", "Default");

Task("Build")
    .Does(() =>
{
    // build the PCL solution
    NuGetRestore("./source/SkiaSharp.Extended.sln");
    DotNetBuild("./source/SkiaSharp.Extended.sln", settings => settings.SetConfiguration("Release"));

    // copy output
    EnsureDirectoryExists("./output/portable");
    CopyFileToDirectory("./source/SkiaSharp.Extended/bin/Release/SkiaSharp.Extended.dll", "./output/portable");

    // build the .NET Standard solution
    DotNetCoreRestore("./source/SkiaSharp.Extended.NetStandard");
    DotNetCoreBuild("./source/SkiaSharp.Extended.NetStandard.sln", new DotNetCoreBuildSettings { Configuration = "Release" });

    // copy output
    EnsureDirectoryExists("./output/netstandard");
    CopyFileToDirectory("./source/SkiaSharp.Extended.NetStandard/bin/Release/SkiaSharp.Extended.dll", "./output/netstandard");
});

Task("Package")
    .IsDependentOn("Build")
    .Does(() =>
{
    NuGetPack ("./nuget/SkiaSharp.Extended.nuspec", new NuGetPackSettings { 
        OutputDirectory = "./output/",
        BasePath = "./",
    });
});

Task("Clean")
    .Does(() =>
{
    CleanDirectories ("./source/*/bin");
    CleanDirectories ("./source/*/obj");
    CleanDirectories ("./source/packages");

    CleanDirectories ("./output");
});

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Package");

RunTarget(target);
