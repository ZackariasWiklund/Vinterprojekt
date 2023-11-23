public class Store
{
    private List<string> availableWords = new List<string> {"Arrestera", "Groda", "Super"};
    private Random random = new Random();

    public string BuyWord()
    {
        if (availableWords.Count == 0)
        {
            Console.WriteLine("Det finns inga ord");
            return null;
        }

        int index = random.Next(availableWords.Count);
        string word = availableWords[index];
        availableWords.RemoveAt(index);
        Console.WriteLine($"Du köpte ett ord: {word}");
        return word;
    }

    public void PrintAvailableWords()
    {
        Console.WriteLine("Ord tillgängliga i butiken:");
        foreach (var word in availableWords)
        {
            Console.WriteLine(word);
        }
    }

}