using BenchmarkDotNet.Attributes;

namespace BenchmarkTests;

public class Benchmarks
{
    private readonly List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Alice" },
        new User { Id = 2, Name = "Bob" },
        new User { Id = 3, Name = "Charlie" }
    };

    [Benchmark]
    public User GetLastItemUsingLinqLast()
    {
        return users.Last();
    }

    [Benchmark]
    public User GetLastItemUsingCountIndex()
    {
        return users[users.Count - 1];
    }

    [Benchmark]
    public User GetLastItemUsingIndexFromEnd()
    {
        return users[^1];
    }
}