public class TamagotchiManager
{
    public List<Tamagotchi> tamagotchis = new List<Tamagotchi>();
    
    public void ViewAllTamagotchis()
    {
        foreach (var tamagotchi in tamagotchis)
        {
            Console.WriteLine($"Namn: {tamagotchi.name}, Hunger: {tamagotchi.hunger}, Boredom: {tamagotchi.boredom}");
        }
        Console.WriteLine();
    }
       

    



}