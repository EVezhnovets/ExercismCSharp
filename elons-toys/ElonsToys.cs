using System;

class RemoteControlCar
{
    private int _distance;
    private int _battery = 100;

    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        if(_distance > 2000)
        {
            return "Driven 2000 meters";
        }
        else
        {
            return String.Format("Driven {0} meters", _distance);
        }
    }

    public string BatteryDisplay()
    {
        if(_battery <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return String.Format("Battery at {0}%", _battery);
        }
    }

    public void Drive()
    {
        _distance += 20;
        _battery -= 1;
    }
}
