using BenchmarkDotNet.Attributes;
using ExtensionMethod.Extensions;

namespace BenchmarkTests;

public class BenchmarksGetItem
{
    private readonly List<User> users = new List<User>
    {
        new User { Id = 1, Name = "Alice" },
        new User { Id = 2, Name = "Bob" },
        new User { Id = 3, Name = "Charlie" }
    };

    [Benchmark]
    public string? GetUserNameByIdUsingLinq()
    {
        var userName = users.FirstOrDefault(user => user.Id == 1)?.Name;
        return userName;
    }

    [Benchmark]
    public string? GetUserNameByIdUsingExtensionMethod()
    {
        var userName = users.GetPropertyById(user => user.Id == 1, user => user.Name);
        return userName;
    }
}