using System;

static class AssemblyLine
{
    public static int carsPerHour = 221;
    public static double SuccessRate(int speed)
    {
        double koef = default, zero = 0, fromOneToFour = 100, fromFiveToEight = 90, nine = 80, ten = 77;
        switch (speed)
        {
            case 0:
                return koef = zero / 100;
            case >= 1 and <= 4:
                return koef = fromOneToFour / 100;
            case >= 5 and <= 8:
                return koef = fromFiveToEight / 100;
            case 9:
                return koef = nine / 100;
            case 10:
                return koef = ten / 100;
        }
        return koef;
    }
    
    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * carsPerHour * speed;

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
