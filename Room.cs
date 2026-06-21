
public class Room
{

    public string Description {get; set;}
    public Room(string description)
    {
        Description = description;  
    }
    
        public void Enter (Zero player)
    {
        while(true)
        {
            Console.WriteLine("You are in the " + Description);
            Console.WriteLine("Choose a door:");
            Console.WriteLine(" - right door");
            Console.WriteLine(" - left door");
            Console.Write(">>> ");

            var choice = (Console.ReadLine() ?? "").ToLower().Trim();

            if(choice == "right door")
            {
                player.Inventory.Add(new Item("Ring", "Invisible ring"));
                Console.WriteLine("You entered the right door.");
                Console.WriteLine("You found an invisible ring.");
                Console.WriteLine("You return to the Hall of Two Doors.");
                Console.WriteLine();
                break; // выход из комнаты
            }
            else if (choice == "left door")
            {
                Console.WriteLine("A guard blocks your way.");
                Console.WriteLine("You must find another way.");
            }
            else
            {
                Console.WriteLine("Nothing happens.");
            }
        }
        while (true)
        {
            Console.WriteLine("You are in the " + Description);
            Console.Write(">>>");
            string choice = (Console.ReadLine() ?? "").ToLower().Trim();
            if(choice == "left door")
            {
                Console.WriteLine("You entered the left door and approached the guard.");
                Console.WriteLine();
                break;
            }
            else if (choice == "right door")
            {
                Console.WriteLine("There is nothing here.");
            }
            else
            {
                Console.WriteLine("Nothing happens.");
            }

        }
    }      
     
}
