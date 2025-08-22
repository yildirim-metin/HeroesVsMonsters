namespace HeroesVsMonstersConsole.Models;

public abstract class Heroes : Character
{
    public override void Hit()
    {
        throw new NotImplementedException();
    }

    public abstract void Rob();
}
