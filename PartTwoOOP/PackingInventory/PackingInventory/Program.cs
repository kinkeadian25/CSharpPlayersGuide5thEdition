Pack pack = new Pack(10, 25, 25);
while (true)
{
    Console.WriteLine(pack);
    Console.WriteLine($"Your pack currently has {pack.NumberOfItems}/{pack.MaxItems} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, " +
        $"and {pack.CurrentVol}/{pack.MaxVol} volume");

    Console.WriteLine("What would you like to add?\n1 - Arrow\n2 - Bow\n3 - Rope\n4 - Water\n5 - Food\n6 - Sword");
    int input = Convert.ToInt32(Console.ReadLine());

    InventoryItem addItem = input switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
    };
    Console.Clear();
    if (!pack.Add(addItem))
    {
        Console.WriteLine("You can't pack that item! Check the numbers to see why");
        Console.WriteLine();
    }
}
