using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public abstract class Character
{
    public int Stamina { get; set; }
    public int Strength { get; set; }
    public int Health { get; set; }

    protected Character()
    {
        Stamina = GetStats();
        Strength = GetStats();
        Health = GetStats();
    }

    private static int GetStats()
    {
        int maxRoll = 4;
        int[] stats = new int[maxRoll];

        Dice dice = new(1, 6);
        for (int i = 0; i < maxRoll; i++)
        {
            stats[i] = dice.Roll();
        }
        return stats.Sum() - stats.Min();
    }

    abstract public void Hit();

    public override string ToString()
    {
        return $"""
            Stamina: {Stamina}
            Strength: {Strength}
            Health: {Health}
            """;
    }
}
