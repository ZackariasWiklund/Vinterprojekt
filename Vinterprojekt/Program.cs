Tamagotchi tama = new Tamagotchi();
Store store = new Store();


Console.WriteLine("Döp din Tamagotchi");
tama.name = Console.ReadLine();
Console.WriteLine();

while (tama.GetAlive() == true)
{
    
    tama.PrintStats();
    Console.WriteLine($"1, lär {tama.name} ett nytt ord");
    Console.WriteLine($"2, få {tama.name} att säga ett ord");
    Console.WriteLine($"3, mata {tama.name}");
    Console.WriteLine("4, gör inget");
    Console.WriteLine("5, Besök Affären");
    Console.WriteLine();


string Val = Console.ReadLine();
if (Val == "1")
{   Console.Clear();
    Console.WriteLine();
    string word = Console.ReadLine();
    tama.Teach(word);
    tama.Tick();
    Console.WriteLine();
}

if (Val == "2")
{   Console.Clear();
    Console.WriteLine();
    tama.Hi();
    tama.Tick();
    Console.WriteLine();
}

if (Val == "3")
{   
    Console.Clear();
    Console.WriteLine();
    tama.Feed();
    tama.Tick();
    Console.WriteLine();
}

else if (Val == "4")
{   Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Du gör inget");
    tama.Tick();
    Console.WriteLine();
}

else if (Val == "5")
{   Console.Clear();
    Console.WriteLine();

    store.PrintAvailableWords();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine($"Du har {store.coins} coins. Vill du köpa ett nytt ord? Ja/Nej");
    string buyVal = Console.ReadLine();
    if (buyVal.ToLower() == "ja")
    {   
        Console.Clear();
        string newWord = store.BuyWord();
        if (newWord != null)
        {
            tama.Teach(newWord);
            tama.Tick();
        }
    }
}
}

tama.Tick();

Console.WriteLine($"{tama.name} dog");

Console.ReadLine();