namespace HeroesVsMonstersConsole.Models;

public class Monster : Character
{
    public List<Item> Items { get; set; }

    public Monster() : base()
    {
        Items = [];
    }

    public override string ToString()
    {
        string toString = $"""
            {base.ToString()}
             - Items :
            """;
        Items.ForEach(i => toString += "\n\t" + "* " + i.ToString());
        return toString;
    }
}
