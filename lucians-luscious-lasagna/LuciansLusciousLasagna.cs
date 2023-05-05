class Lasagna
{
    int minutesInOven = 40;
    int minutesPrapareLayer = 2;
    public int ExpectedMinutesInOven()
    {
        return minutesInOven;
    }

    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        int remainMinutesInOven = minutesInOven - actualMinutesInOven;
        return remainMinutesInOven;
    }
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        int minutesPrepareAllLayers = minutesPrapareLayer * numberOfLayers;
        return minutesPrepareAllLayers;
    }

    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven)
    {
        int elapsedMinutes = numberOfLayers * minutesPrapareLayer + actualMinutesInOven;
        return elapsedMinutes;
    }
}