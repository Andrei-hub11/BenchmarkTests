using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class BenchmarksTryParse
{
    private static readonly string GuidTest = Guid.NewGuid().ToString();

    [Benchmark]
    public bool TryMethod()
    {
        Guid result;
        return Guid.TryParse(GuidTest, out result);
    }

    [Benchmark]
    public bool TryMethodWithUnderscore()
    {
        return Guid.TryParse(GuidTest, out _);
    }
}
