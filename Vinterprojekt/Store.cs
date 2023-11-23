public class Store
{
    private List<string> availableWords = new List<string> {"Arrestera", "Groda", "Super", "Scratch", "Devilish", "Lunch", "Kindly"};
    private Random random = new Random();
    public int coins = 10;

    public string BuyWord()
    {
        if (coins <= 0)
        {
            Console.WriteLine("Du har inte tillräckligt med coins");
            return null;
        }
        
        if (availableWords.Count == 0)
        {
            Console.WriteLine("Det finns inga ord");
            return null;
        }

        int index = new Random().Next(availableWords.Count);
        string word = availableWords[index];
        availableWords.RemoveAt(index);
        coins-=3;
        Console.WriteLine($"Du köpte ett ord: {word}");
        Console.WriteLine($"Du har {coins} kvar");
        return word;
    }

    public void PrintAvailableWords()
    {   
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ord tillgängliga i butiken:");
        foreach (var word in availableWords)
        {   
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(word);
        }
    }

}