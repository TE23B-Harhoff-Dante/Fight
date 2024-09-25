
using System.Threading.Tasks.Dataflow;
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

Console.WriteLine($"{name} {hp1}hp VS {name}killer {hp2}hp");
Console.WriteLine("Skriv a för att göra 0-20 skada");

choice = Console.ReadLine();

while (hp1 > 0 && hp2 > 0)
{

    if (choice.ToLower() == "a")
        skada = Random.Shared.Next(0, 21);

    Console.WriteLine($"{name} gjorde {skada} skada");

    hp1 -= skada;
    skada = Random.Shared.Next(0, 21);
    hp2 -= skada;

    Console.WriteLine($"{name}killer gjorde {skada} skada");

    Console.WriteLine($"{name} har kvar {hp1}hp och {name}killer har kvar {hp2}hp");
    Console.ReadLine();
}

if (hp1 > 0)
{
    Console.WriteLine(" YOU WIN");
}

else if (hp2 > 0)
{
    Console.WriteLine(" YOU LOSE");
}
else
{
    Console.WriteLine("DRAW");
}




Console.ReadLine();

