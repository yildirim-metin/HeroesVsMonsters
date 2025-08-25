namespace HeroesVsMonstersConsole.Models;

public abstract class Heroes : Character
{
    protected Heroes() : base()
    {
    }

    public override void Hit()
    {
        throw new NotImplementedException();
    }

    public abstract void Loot();
}
