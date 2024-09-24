
using System.Xml.Serialization;

int hp1 = Random.Shared.Next(80, 101);
int hp2 = Random.Shared.Next(80, 101);

int skada = Random.Shared.Next(0, 21);
string choice = "";


Console.WriteLine("Skriv ditt namn");
String name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("bruh");
    Console.WriteLine("försök igen");
    name = Console.ReadLine();
}

Console.WriteLine($"{name} {hp1}hp VS Demon {hp2}hp");
Console.WriteLine("Skriv a för att göra 0-20 skada");

choice = Console.ReadLine();

while (hp1 > 0 && hp2 > 0)
{

    if (choice.ToLower() == "a")
        hp1 -= skada;


    hp2 -= skada;

    Console.WriteLine($"{name} har kvar {hp1}hp och Demon har kvar {hp2}hp");
    Console.ReadLine();

}

Console.ReadLine();

