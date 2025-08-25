namespace HeroesVsMonstersConsole.Models;

public class Human : Heroes
{
    public Human() : base()
    {
        Stamina = GetStats() + 1;
        Strength = GetStats() + 1;
    }

    public override void Rob()
    {
        throw new NotImplementedException();
    }
}
