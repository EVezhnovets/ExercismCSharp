class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }
    public int Distance { get; set; }
    public int Battery { get; set; } = 100;

    public RemoteControlCar(int speed, int drain)
    {
        Speed = speed;
        BatteryDrain = drain;
    }

    public bool BatteryDrained()
    {
        if (Battery <= 0 || Battery < BatteryDrain) return true;
        else return false;
    }

    public int DistanceDriven()
    {
        return Distance;
    }

    public void Drive()
    {
        if (Battery <= 0 || Battery < BatteryDrain) return;
        else
        {
            Distance += Speed;
            Battery -= BatteryDrain;
        }

    }

    public static RemoteControlCar Nitro()
    {
        var nitroCar = new RemoteControlCar(50, 4);
        return nitroCar;
    }
}

class RaceTrack
{
    public double Distance { get; set; }

    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var i = Distance / car.Speed * car.BatteryDrain;
        var result = i <= 100;
        return result;
    }
}