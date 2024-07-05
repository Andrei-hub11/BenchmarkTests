using System.Diagnostics.CodeAnalysis;

namespace BenchmarkTests.Extensions;
public static class CollectionExtensions
{
    public static TProperty GetPropertyById<T, TProperty>(this IEnumerable<T> collection, Func<T, bool> idPredicate, Func<T, TProperty> propertySelector)
    {
        if (collection == null) throw new ArgumentNullException(nameof(collection));
        if (idPredicate == null) throw new ArgumentNullException(nameof(idPredicate));
        if (propertySelector == null) throw new ArgumentNullException(nameof(propertySelector));

        var item = collection.FirstOrDefault(idPredicate);

        return item is not null ? propertySelector(item) : default;
    }

    public static bool MatchString(this string str1, string str2)
    {
        return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
    }
}
