using BenchmarkDotNet.Attributes;
using BenchmarkTests.Extensions;
using System.Collections.Generic;

namespace BenchmarkTests;

public class BenchmarksAllOrTrueForAll
{
    private List<int> _array;

    [Params(100, 1000, 10000)]
    public int ArraySize { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _array = new List<int>(ArraySize);
        _array.AddRange(BenchmarkArrayGenerator.GenerateIntArray(ArraySize));
    }

    [Benchmark]
    public bool AllMethod()
    {
       return _array.All(x => x == 0);
    }

    [Benchmark]
    public bool TrueForAllMethod()
    {
       return _array.TrueForAll(x => x == 0);
    }
}