using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class BenchmarksNameofOrToString
{

    [Benchmark]
    public string UsingNameof()
    {
        var user = new User { Name = "Andy"};
        return nameof(user.Name);
    }

    [Benchmark]
    public string UsingToString()
    {
        var user = new User { Name = "Andy" };
        return user.Name.ToString();
    }
}
