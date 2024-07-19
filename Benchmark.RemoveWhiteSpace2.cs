using AzureBlobStorageTest.Extensions;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class BenchmarkRemoveWhiteSpace_Collection
{
    private readonly string shortString;
    private readonly string mediumString;
    private readonly string longString;

    public BenchmarkRemoveWhiteSpace_Collection()
    {
        shortString = "This is a short string.";
        mediumString = new string('a', 1500) + " " + new string('b', 1500);
        longString = new string('a', 10000) + " " + new string('b', 10000);
    }

    [Benchmark]
    public string RemoveWhiteSpace_Short()
    {
        return shortString.RemoveWhiteSpace();
    }

    [Benchmark]
    public string RemoveWhiteSpaceRegex_Short()
    {
        return shortString.RemoveAllWhiteSpace();
    }

    [Benchmark]
    public string RemoveWhiteSpace_Medium()
    {
        return mediumString.RemoveWhiteSpace();
    }

    [Benchmark]
    public string RemoveWhiteSpaceRegex_Medium()
    {
        return mediumString.RemoveAllWhiteSpace();
    }

    [Benchmark]
    public string RemoveWhiteSpace_Long()
    {
        return longString.RemoveWhiteSpace();
    }

    [Benchmark]
    public string RemoveWhiteSpaceRegex_Long()
    {
        return longString.RemoveAllWhiteSpace();
    }
}
