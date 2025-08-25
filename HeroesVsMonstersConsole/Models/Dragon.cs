namespace HeroesVsMonstersConsole.Models;

public class Dragon : Monster
{
    public override int Stamina => base.Stamina + 1;

    public Dragon() : base()
    {
    }
}
