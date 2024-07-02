using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class BenchmarksAnyOrExits
{
    private readonly List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Alice" },
        new User { Id = 2, Name = "Bob" },
        new User { Id = 3, Name = "Charlie" }
    };

    [Benchmark]
    public bool ExitsMethod()
    {
        return users.Exists(user => user.Id == 1);
    }

    [Benchmark]
    public bool AnyMethod()
    {
        return users.Any(user => user.Id == 1);
    }
}
