namespace HeroesVsMonstersConsole.Models;

public class Orca : Monster
{
    public override int Strength => base.Strength + 1;

    public Orca() : base()
    {
    }
}
