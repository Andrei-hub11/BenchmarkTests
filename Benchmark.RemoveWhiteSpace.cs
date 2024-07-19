using AzureBlobStorageTest.Extensions;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class BenchmarkRemoveWhiteSpace
{
    private const string TestString = "This is a sample string with    multiple spaces and tabs.";

    [Benchmark]
    public string RemoveWhiteSpaceMethod()
    {
        return TestString.RemoveWhiteSpace();
    }

    [Benchmark]
    public string RemoveAllWhiteSpaceMethod()
    {
        return TestString.RemoveAllWhiteSpace();
    }
}
