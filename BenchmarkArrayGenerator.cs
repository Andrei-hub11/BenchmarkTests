namespace BenchmarkTests;

public static class BenchmarkArrayGenerator
{
    private static Random _random = new Random();

    public static int[] GenerateIntArray(int size, int minValue = 0, int maxValue = 1000)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = _random.Next(minValue, maxValue);
        }
        return array;
    }
}

