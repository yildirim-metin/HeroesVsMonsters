using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public class Dragon : Monster
{
    public override int Stamina => base.Stamina + 1;

    public Dragon() : base()
    {
        int leatherQuantity = new Dice(1, 4).Roll();
        for (int i = 0; i < leatherQuantity; i++)
        {
            Items.Add(new Leather());
        }

        int goldQuantity = new Dice(1, 8).Roll();
        for (int i = 0; i < goldQuantity; i++)
        {
            Items.Add(new Gold());
        }
    }
}
