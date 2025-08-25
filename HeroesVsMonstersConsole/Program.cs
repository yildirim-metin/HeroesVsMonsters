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