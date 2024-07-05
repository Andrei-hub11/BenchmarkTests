using System.Diagnostics.CodeAnalysis;

namespace BenchmarkTests.Extensions;

public static class Utils
{
    public static bool IsNotNull([NotNullWhen(true)] object? obj) => obj != null;
}

