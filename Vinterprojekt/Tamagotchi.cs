using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    public List<string> words = new() {"Hello"};
    private bool isAlive;
    private Random generator  = new Random();

    public string name;

    private int coins = 0; 

    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine($"{name} äter och blir mindre hungrig");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = -1;
        }
    }

    public void ReduceBoredom()
    {
        boredom -= 2;
        if(boredom < 0)
        {
            boredom = 0;
        }
    }

    public void Hi()
    {
        int wordnum = generator.Next(words.Count);
        Console.WriteLine($"{words[wordnum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if(hunger >10 || boredom >10)
        {
            isAlive = false;
        }
    }
    
    public void PrintStats()
    {
    
    Console.Write("Name: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{name}");
    Console.ResetColor();

    Console.Write(" || ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"Hunger: {hunger}");
    Console.ResetColor();

    Console.Write(" || ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"Boredom: {boredom}");
    Console.ResetColor();

    Console.Write(" || ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Vocabulary: {words.Count} words");
    Console.ResetColor();
    }

    public bool GetAlive()
    {
        return isAlive;
    }
}