using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public class Dragon : Monster
{
    public override int Stamina => base.Stamina + 1;

    public Dragon() : base()
    {
        List<Item> items = [];
        int leatherQuantity = new Dice(1, 4).Roll();
        for (int i = 0; i < leatherQuantity; i++)
        {
            items.Add(new Leather());
        }
        
        int goldQuantity = new Dice(1, 8).Roll();
        for (int i = 0; i < goldQuantity; i++)
        {
            items.Add(new Gold());
        }

        Items = items;
    }
}
