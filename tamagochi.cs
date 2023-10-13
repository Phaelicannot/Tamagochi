using System;
using System.Collections.Generic;

public class tamagotchi
{
    Random generator = new Random();
    public string name;
    public string act;
    private int boredom;
    private int tickCount = 0;
    private bool nothing = false;
    private int hungerLevel;
    private int boredomLevel;
    private bool isAlive = true;
    private string food;
    List<string> words = new()
    {
        "squeak"
    };
   
    

    public bool GetAlive()
    {
        if (isAlive == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void Tick()
    {
        if (nothing == false)
        {
            hungerLevel++;
            boredomLevel++;
            tickCount++;
            if (tickCount == 1)
            {
                Console.WriteLine($"By the way, just because I can, I have made {name} get extra hungry and bored every 5 rounds from now on.");
            }
            if (tickCount >= 7)
            {
                boredomLevel++;
                hungerLevel++;
                Console.WriteLine($"{name} gets extra hungry and bored this round.");
                tickCount = 2;
            }
            if (hungerLevel > 10 || boredomLevel > 10)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }
        }
        else 
        {
            nothing = false;
        }
    }
    public void Wait()
    {
        int bored = generator.Next(3);
        boredomLevel += bored;
    }
    public void Hi()
    {
        if (boredomLevel >= 2)
        {
            int whatWord = generator.Next(words.Count);
            Console.WriteLine($"{name} responds with '{words[whatWord]}'");
            ReduceBoredom(3);
        }
        else
        {
            Console.WriteLine($"{name} doesn't want to speak with you right now. Try again when it is more bored.");
        }
    }
    public void Play()
    {
        if (boredomLevel >= 4)
        {
            Console.WriteLine($"You play with {name}.");
            Console.WriteLine($"{name} becomes less bored, but a little more hungry.");
            ReduceBoredom(4);
            hungerLevel++;
        }
        else
        {
            Console.WriteLine($"{name} doesn't want to play with you right now. Try again when it is more bored.");
        }
    }
    public void Feed()
    {
        food = Console.ReadLine();
        if (food == "1")
        {
            hungerLevel -= 3;
            Console.WriteLine($"You feed {name} a carrot");
        }
        if (food == "2")
        {
            hungerLevel -= 2;
            Console.WriteLine($"You feed {name} some peas");
        }
        if (food == "3")
        {
            hungerLevel -= 4;
            Console.WriteLine($"You feed {name} an apple");
        }
        if (food == "4")
        {
            nothing = true;
            act = "0";
        }
        if (hungerLevel <= -2)
        {
            hungerLevel = 10;
            Console.WriteLine($"You overfed {name}.");
        }
        if (food != "4")
        {
            Console.WriteLine($"{name} becomes less hungry.");
        }
    }
    public void Teach(string newWord)
    {
        if (newWord == "1")
        {
            nothing = true;
            act = "0";
        }
        else
        {
            Console.WriteLine($"You taught {name} the word: {newWord}");
            words.Add(newWord);
            Console.WriteLine($"{name} found it slightly entertaining.");
            ReduceBoredom(3);
        }
       
    }
    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hungerLevel}");
        Console.WriteLine($"Boredom: {boredomLevel}");
    }

    private void ReduceBoredom(int boredom)
    {
        boredomLevel -= boredom;
        if (boredomLevel < 0)
        {
            boredomLevel = 0;
        }
    }




}
