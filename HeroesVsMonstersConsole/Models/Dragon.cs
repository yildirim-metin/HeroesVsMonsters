namespace HeroesVsMonstersConsole.Models;

public class Dragon : Monster
{
    public Dragon() : base()
    {
        Stamina = GetStats() + 1;
    }
}
