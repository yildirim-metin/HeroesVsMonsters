namespace HeroesVsMonstersConsole.Models;

public class Human : Heroes
{

    public override int Stamina => base.Stamina + 1;
    public override int Strength => base.Strength + 1;

    public Human() : base()
    {
    }

    public override void Loot()
    {
        throw new NotImplementedException();
    }
}
