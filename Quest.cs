public class Quest
{
    public void Start()
    {
        Zero player = new Zero("Zero");
        Room room = new Room("Hall of Two Doors");
        room.Enter(player);
        Console.WriteLine("=== INVENTORY ===");
        foreach (var item in player.Inventory)
        {
            Console.WriteLine($"Found item:  {item.Name}");
        }

        
        var ring = player.Inventory.Find(i => i.Name == "Ring");

        if (ring != null)
        {
            
            Console.WriteLine();
            Console.WriteLine($"You use the {ring.Name}.");
            Console.WriteLine("The guard cannot see you.");
            Console.WriteLine("You quietly pass by.");
        }
        Console.WriteLine("Quest completed.");
    }
}