Sword basic = new Sword(MaterialType.Iron, GemType.None, 50, 10);
Sword enhanced = new Sword(MaterialType.Binarium, GemType.Sapphire, 70, 18);
Sword wonky = new Sword(MaterialType.Wood, GemType.Bitstone, 40, 20);

Console.WriteLine(basic);
Console.WriteLine(enhanced);
Console.WriteLine(wonky);

public record Sword(MaterialType materialType, GemType gemType, int length, int crossguardWidth); 
public enum MaterialType { Wood, Bronze, Iron, Steel, Binarium }
public enum GemType { Emerald, Amber, Sapphire, Diamond, Bitstone, None}