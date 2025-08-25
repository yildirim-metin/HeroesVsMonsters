namespace HeroesVsMonstersConsole.Models;

public class Drawf : Heroes
{
    public override int Stamina => base.Stamina + 2;

    public Drawf()
    {
    }

    public override void Loot()
    {
        throw new NotImplementedException();
    }
}
