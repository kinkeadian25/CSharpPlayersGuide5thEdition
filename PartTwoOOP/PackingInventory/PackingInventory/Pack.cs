public class Pack
{
    public int MaxItems { get; set; }
    public float MaxWeight { get; set; }
    public float MaxVol { get; set; }
    private InventoryItem[] _items;
    public int NumberOfItems { get; private set; }
    public float CurrentWeight { get; private set; }
    public float CurrentVol { get; private set; }
    public Pack(int maxItems, float maxWeight, float maxVol)
    {
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVol = maxVol;

        _items = new InventoryItem[MaxItems];
    }

    public bool Add(InventoryItem item)
    {
        if(NumberOfItems >= MaxItems) return false;
        if(CurrentWeight + item.Weight > MaxWeight) return false;
        if(CurrentVol + item.Volume > MaxVol) return false;

        _items[NumberOfItems] = item;
        NumberOfItems++;
        CurrentVol = CurrentVol + item.Volume;
        CurrentWeight = CurrentWeight + item.Weight;
        return true;
    }
}
