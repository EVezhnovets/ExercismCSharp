public class SpaceAge
{
    public double Seconds { get; set; }
    public const double secYear = 31557600;
    public SpaceAge(int seconds) => Seconds = seconds;

    public double OnEarth() => Seconds / secYear;

    public double OnMercury() => Seconds / secYear / 0.2408467;

    public double OnVenus() => Seconds / secYear / 0.61519726;

    public double OnMars() => Seconds / secYear / 1.8808158;

    public double OnJupiter() => Seconds / secYear / 11.862615;

    public double OnSaturn() => Seconds / secYear / 29.447498;

    public double OnUranus() => Seconds / secYear / 84.016846;

    public double OnNeptune() => Seconds / secYear / 164.79132;
}