namespace HeroesVsMonstersConsole.Models;

public class Drawf : Heroes
{
    public Drawf()
    {
        Stamina = GetStats() + 2;
    }

    public override void Rob()
    {
        throw new NotImplementedException();
    }
}
