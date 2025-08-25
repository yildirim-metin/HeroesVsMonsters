namespace HeroesVsMonstersConsole.Models;

public abstract class Item
{
    public abstract string Name { get; }

    public override string ToString()
    {
        return Name;
    }
}
