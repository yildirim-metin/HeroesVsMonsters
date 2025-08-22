namespace HeroesVsMonstersConsole.Models;

public abstract class Character
{
    public int Stamina { get; set; }
    public int Strength { get; set; }
    public int Health { get; set; }

    protected Character()
    {    
    }

    abstract public void Hit();
}
