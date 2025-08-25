using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public abstract class Character
{
    public virtual int Stamina { get; private set; }
    public virtual int Strength { get; private set; }
    public int Health { get; private set; }

    protected Character()
    {
        Stamina = GetStatValue();
        Strength = GetStatValue();
        Health = GetHealth();
    }

    private static int GetStatValue()
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

    private int GetHealth()
    {
        int value;
        if (Stamina < 5)
        {
            value = Stamina - 1;
        }
        else if (Stamina < 10)
        {
            value = Stamina;
        }
        else if (Stamina < 15)
        {
            value = Stamina + 1;
        }
        else
        {
            value = Stamina + 2;
        }
        return value;
    }

    abstract public void Hit();

    public override string ToString()
    {
        return $"""
            # {GetType().Name}
             - Stamina: {Stamina}
             - Strength: {Strength}
             - Health: {Health}
            """;
    }
}
