namespace HeroesVsMonstersConsole.Utils;

public class Dice
{
    public int Min { get; }
    public int Max { get; }

    public Dice(int min, int max)
    {
        Min = min;
        Max = max;
    }

    public int Roll()
    {
        Random r = new();
        return r.Next(Min, Max);
    }
}
