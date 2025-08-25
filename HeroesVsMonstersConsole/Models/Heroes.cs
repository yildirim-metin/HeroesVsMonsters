namespace HeroesVsMonstersConsole.Models;

public abstract class Heroes : Character
{
    protected Heroes() : base()
    {
    }

    public abstract void Loot();
}
