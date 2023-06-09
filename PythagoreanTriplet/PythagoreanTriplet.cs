using System.Collections.Generic;
public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int n)
    {
        var result = new List<(int, int, int)>();
        for (int a = 1; a < n / 3; a++)
        {
            for (int b = a + 1; b <= n / 2; b++)
            {
                var c = n - a - b;
                if (a * a + b * b == c * c)
                {
                    result.Add((a, b, c));
                }
            }
        }
        return result;
    }
}