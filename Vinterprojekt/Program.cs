Tamagotchi tama = new Tamagotchi();
List<Tamagotchi> TamaList = new List<Tamagotchi>();
Store store = new Store();
TamagotchiManager manager = new TamagotchiManager();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"
                             _____                                 _       _     _ 
                            |_   _|                               | |     | |   (_)
                              | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ 
                              | |/ _` | '_ ` _ \ / _` |/ _` |/ _ \| __/ __| '_ \| |
                              | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |
                              \_/\__,_|_| |_| |_|\__,_|\__, |\___/ \__\___|_| |_|_|
                                                        __/ |                      
                                                       |___/                       
                           _________________________________________________________ ");
    
Console.ForegroundColor = ConsoleColor.White;    
Console.WriteLine();
Console.WriteLine();                                   
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
    Console.WriteLine("6, Kasta boll");
    Console.WriteLine("7, Köp en ny Tamagotchi");
    Console.WriteLine("8, Inspektera Tamagotchis");
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

else if (Val == "6")
{   
    Console.Clear();
    Console.WriteLine();

    tama.CatchGame(store);
    
}

else if (Val == "7")
{
    Console.Clear();
    Console.WriteLine("Ange namn för den nya Tamagotchin:");
    string newName = Console.ReadLine();
    Tamagotchi newTama = new Tamagotchi();
    newTama.name = newName;
    TamaList.Add(newTama);
    
    

    Console.WriteLine($"Du har köpt en ny Tamagotchi och döpt den till {newName}.");
}

else if (Val == "8")
{
    Console.Clear();
    Console.WriteLine("Dina Tamagotchis:");
    Console.WriteLine();          
    foreach (var newTama in TamaList)
    {
        Console.WriteLine($"Tamagotchi namn: {newTama.name}");
        
        Console.WriteLine();
        
    }  
    
}

}

tama.Tick();

Console.WriteLine($"{tama.name} dog");

Console.ReadLine();