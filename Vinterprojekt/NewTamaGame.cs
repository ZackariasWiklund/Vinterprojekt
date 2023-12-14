public class RunNewTamaGame
{
public void RunTamagotchiGame(Tamagotchi selectedTama)
{
    
    TamagotchiGame tamagogame = new TamagotchiGame();
    Console.WriteLine();

    while (selectedTama.GetAlive())
    {
        Console.WriteLine("Interagera med Tamagotchin:");
        Console.WriteLine("1. Lär ett nytt ord");
        Console.WriteLine("2. Få den att säga ett ord");
        Console.WriteLine("3. Mata Tamagotchin");
        Console.WriteLine("4, Tillbaka till huvud tamagotchi");
        

        string choice = Console.ReadLine();

       
        if (choice == "1")
        {
            Console.WriteLine("Ange ett nytt ord:");
            string newWord = Console.ReadLine();
            selectedTama.Teach(newWord);
            selectedTama.Tick();
            selectedTama.PrintStats();
            Console.WriteLine();
        }
        else if (choice == "2")
        {
            Console.WriteLine("Tamagotchin säger:");
            selectedTama.Hi();
            selectedTama.Tick();
            selectedTama.PrintStats();
            Console.WriteLine();
        }
        else if (choice == "3")
        {
            selectedTama.Feed();
            selectedTama.Tick();
            selectedTama.PrintStats();
            Console.WriteLine();
        }
        else if (choice == "4")
        {   
            Console.Clear();
            tamagogame.TamaGame();
        }
        

        else
        {
            Console.WriteLine("Ogiltigt val. Försök igen.");
            Console.ReadLine();
        }
    }

    selectedTama.Tick();

    Console.WriteLine($"{selectedTama.name} dog");
    Console.ReadLine();
}
}