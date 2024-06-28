using System.Diagnostics.CodeAnalysis;

namespace ExtensionMethod.Extensions;

public static class Utils
{
    public static bool IsNotNull([NotNullWhen(true)] object? obj) => obj != null;
}

