namespace HeroesVsMonstersConsole.Models;

public abstract class Hero : Character
{
    protected Hero() : base()
    {
    }

    public void Loot(Monster monster)
    {
        Items = monster.Items;

        int goldCount = Items.Count(i => i is Gold);
        int leatherCount = Items.Count(i => i is Leather);

        Console.WriteLine($"You looted : {goldCount} gold and {leatherCount} leather");
    }
}
