using BenchmarkDotNet.Attributes;
using ExtensionMethod.Extensions;

namespace BenchmarkTests;

public class BenchmarksString
{

    [Benchmark]
    public bool IsEqual()
    {
        string str1 = "aa";
        string str2 = "aa";

        return str1.ToLower() == str2.ToLower();
    }

    [Benchmark]
    public bool IsEqualUsingEqualMethod()
    {
        string str1 = "aa";
        string str2 = "aa";

        return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
    }
}