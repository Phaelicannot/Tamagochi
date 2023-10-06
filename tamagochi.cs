using System;

public class tamagochi
{
    Random generator = new Random();
    public string name;
    public string act;
    private int hungerLevel;
    private int boredomLevel;
    private bool isAlive;
    List<string> words = new();
    List<int> foods = new()
    {
        1, 3, 2
    };
    // Dictionary<string, int> foods = new(){
    //     {"carrot", 1},
    //     {"apple pie", 3},
    //     {"tears of your enemies", 2}
    // };



    public bool GetAlive();
    public void Tick();
    public void Hi();
    public void Feed()
    {
        hungerLevel -= 2;
    }
    public void Teach()
    {
        words.Add(newWord);
    }
    public void PrintStats();
    private void ReduceBoredom();




}
