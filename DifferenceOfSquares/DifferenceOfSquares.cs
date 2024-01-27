public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int[] arr = new int[max];
        int sum = 0;
        for (int i = 0; i < max; i++)
        {
            arr[i] = i + 1;
            sum += arr[i];
        }

        int sqrSum = (int)Math.Pow(sum, 2);
        return sqrSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int[] arr = new int[max];
        int sum = 0;
        for (int i = 0; i < max; i++)
        {
            arr[i] = (int)Math.Pow(i + 1, 2);
            sum += arr[i];
        }

        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int squareOfSum = CalculateSquareOfSum(max);
        int sumOfSquares = CalculateSumOfSquares(max);

        return squareOfSum - sumOfSquares;
    }
}