using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public class Wolf : Monster
{
    public Wolf() : base()
    {
        List<Item> items = [];
        int leatherQuantity = new Dice(1, 3).Roll();
        for (int i = 0; i < leatherQuantity; i++)
        {
            items.Add(new Leather());
        }
        Items = items;
    }
}
