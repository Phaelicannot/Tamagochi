
using Microsoft.VisualBasic;

Console.WriteLine("Welcome! I will now throw you the responsibility of taking care of this creature.");

tamagochi eggcreature = new tamagochi();

Console.WriteLine("What do you want to name the little guy?");
eggcreature.name = Console.ReadLine();

Console.WriteLine($"{eggcreature.name}? Sounds like a nice name!");
Console.ReadLine();
Console.WriteLine("I think...");
Console.ReadLine();
Console.WriteLine("Anyways! You will have to feed and play with your little friend, or else it will die.");
Console.ReadLine();
Console.WriteLine("But you wouldn't let such an innocent creature die, would you? I trust you. Treat it well. No pressure.");
Console.ReadLine();
Console.WriteLine("*Write the numbers corresponding to the action you want to do.*");
Console.ReadLine();

eggcreature.act = Console.ReadLine();
while (eggcreature.act != "1" && eggcreature.act != "2" && eggcreature.act != "3")
{
    Console.WriteLine("1: Feed          2: Hi         3: Teach          4: Play");
    if (eggcreature.act != "1" && eggcreature.act != "2" && eggcreature.act != "3")
    {
        System.Console.WriteLine("Sorry?");
    }
}

if (eggcreature.act == "1")
{
    int food = Console.ReadLine();
    if (food == 1)
    {
        
    }
    eggcreature.Feed();
}
if (eggcreature.act == "2")
{

}
if (eggcreature.act == "3")
{
    Console.WriteLine($"What word would you like to teach {eggcreature.name}?");
    string newWord = Console.ReadLine();
    eggcreature.Teach();
}




