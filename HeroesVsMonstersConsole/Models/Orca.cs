namespace HeroesVsMonstersConsole.Models;

public class Orca : Monster
{
    public Orca() : base()
    {
        Strength = GetStats() + 1;
    }
}
