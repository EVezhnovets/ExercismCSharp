using System;

public class Player
{
    public int RollDie() => new Random().Next(1, 18);

    public double GenerateSpellStrength() => (double)new Random().Next(0, 1000) / 10;
}