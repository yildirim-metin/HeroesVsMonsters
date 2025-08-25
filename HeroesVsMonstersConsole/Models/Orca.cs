using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public class Orca : Monster
{
    public override int Strength => base.Strength + 1;

    public Orca() : base()
    {
        List<Item> items = [];
        int goldQuantity = new Dice(2, 15).Roll();
        for (int i = 0; i < goldQuantity; i++)
        {
            items.Add(new Gold());
        }
        Items = items;
    }
}
