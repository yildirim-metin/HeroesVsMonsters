namespace HeroesVsMonstersConsole.Models;

public class Human : Hero
{
    public override int Stamina => base.Stamina + 1;
    public override int Strength => base.Strength + 1;

    public Human() : base()
    {
    }
}
