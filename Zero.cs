public class Zero
{
    public string Name { get; set; }

    public List<Item> Inventory { get; set; }

    public Zero(string name)
    {
        Name = name;

        Inventory = new List<Item>();
    }
}