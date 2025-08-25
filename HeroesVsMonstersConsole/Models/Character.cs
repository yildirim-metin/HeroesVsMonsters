using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public abstract class Character
{
    private List<Item> _items = [];

    public virtual int Stamina { get; private set; }
    public virtual int Strength { get; private set; }
    public int Health { get; private set; }
    public List<Item> Items
    {
        get => [.. _items]; protected set => _items.AddRange(value);
    }

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

    public void Hit(Character oppenent)
    {
        int damage = new Dice(1, 4).Roll();

        if (Strength < 5)
        {
            oppenent.Health -= damage - 1;
        }
        else if (Strength < 10)
        {
            oppenent.Health -= damage;
        }
        else if (Strength < 15)
        {
            oppenent.Health -= damage + 1;
        }
        else
        {
            oppenent.Health -= damage + 2;
        }
    }

    public override string ToString()
    {
        string toString = $"""
            # {GetType().Name}
             - Stamina: {Stamina}
             - Strength: {Strength}
             - Health: {Health}
             - Items :
            """;
        Items.ForEach(i => toString += "\n\t" + "* " + i.ToString());
        return toString;
    }
}
