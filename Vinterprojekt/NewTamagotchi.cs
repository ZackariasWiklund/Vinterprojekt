public class NewTamamagotchi : Tamagotchi
{   
    
    public void AssignName(string newName)
    {
        name = newName; // Tilldela det angivna namnet till namnvariabeln i Tamagotchi
    }
    private string tamagotchiName; // A field to hold the Tamagotchi's name

    
    
    public void NewPrintStats()
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
}
    
