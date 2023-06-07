public static class Darts
{
	public static int Score(double x, double y)
	{
		int outerRadius = 10;
		int middleRadius = 5;
		int innerRadius = 1;

		if (ChekRange(x, y, innerRadius))
		{
			return ChekZone(x, y, innerRadius) ? 5 : 10;
		}
		if (ChekRange(x, y, middleRadius))
		{
			return ChekZone(x, y, middleRadius) ? 1 : 5;
		}
		if (ChekRange(x, y, outerRadius))
		{
			return ChekZone(x, y, outerRadius) ? 0 : 1;
		}
		else return 0;
	}

	private static bool ChekZone(double x, double y, int radius) => Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(radius, 2);
	private static bool ChekRange(double x, double y, int radius) => (x >= -radius && x <= radius) && (y >= -radius) && y <= radius;
}