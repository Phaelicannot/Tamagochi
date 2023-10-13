
using Microsoft.VisualBasic;

Console.WriteLine("Welcome! I will now throw you the responsibility of taking care of this creature.");

tamagotchi eggcreature = new tamagotchi();

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

eggcreature.GetAlive();

while (eggcreature.GetAlive() == true)
{
    while (eggcreature.act != "1" && eggcreature.act != "2" && eggcreature.act != "3" && eggcreature.act != "4" && eggcreature.act != "5")
    {
        Console.WriteLine("1: Feed          2: Hi         3: Teach          4: Play          5: Wait");
        eggcreature.act = Console.ReadLine();
        if (eggcreature.act != "1" && eggcreature.act != "2" && eggcreature.act != "3" && eggcreature.act != "4" && eggcreature.act != "5")
        {
            System.Console.WriteLine("Sorry?");
        }
    }

    if (eggcreature.act == "1")
    {
        Console.WriteLine($"What do you want to feed {eggcreature.name}? Do not overfeed it, or it will die.");
        Console.WriteLine("1: Carrot (-2 hunger)           2: Peas (-1 hunger)           3: Apple (-3 hunger)            4: Nevermind");
        eggcreature.Feed();
    }
    if (eggcreature.act == "2")
    {
        Console.WriteLine($"You say hi to {eggcreature.name}");
        eggcreature.Hi();
    }
    if (eggcreature.act == "3")
    {   
        Console.WriteLine($"What word would you like to teach {eggcreature.name}? Type '1' if you want to go back");
        string newWord = Console.ReadLine();
        eggcreature.Teach(newWord);
    }
    if (eggcreature.act == "4")
    {
        Console.WriteLine($"You play with {eggcreature.name}");
        eggcreature.Play();
    }
    if (eggcreature.act == "5")
    {
        Console.WriteLine($"You let {eggcreature.name} sit and stare into a wall. Pretty boring.");
        eggcreature.Wait();
    }
    eggcreature.Tick();
    if (eggcreature.GetAlive() == true)
    {
        eggcreature.PrintStats();
    }
    eggcreature.act = "0";
}

Console.WriteLine($"{eggcreature.name} died");
Console.WriteLine("Wow, I should have known... To be honest, I think a potato could do a better job than you.");
Console.ReadLine();


