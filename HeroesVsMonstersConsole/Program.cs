using HeroesVsMonstersConsole.Models;

Console.WriteLine("Heroes VS Monsters");

List<Character> characters =
[
    new Human(),
    new Dragon(),
    new Orca(),
    new Drawf(),
    new Wolf(),
];

foreach (var c in characters)
{
    Console.WriteLine(c);
}

Console.WriteLine("##### FIGHT #####");
characters[1].Hit(characters[2]);
characters[2].Hit(characters[1]);

characters.Take(1..3).ToList().ForEach(Console.WriteLine);