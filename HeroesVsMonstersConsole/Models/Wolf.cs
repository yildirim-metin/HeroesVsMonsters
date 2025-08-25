using HeroesVsMonstersConsole.Utils;

namespace HeroesVsMonstersConsole.Models;

public class Wolf : Monster
{
    public Wolf() : base()
    {
        int leatherQuantity = new Dice(1, 3).Roll();
        for (int i = 0; i < leatherQuantity; i++)
        {
            Items.Add(new Leather());
        }
    }
}
