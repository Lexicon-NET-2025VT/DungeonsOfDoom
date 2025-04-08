namespace DungeonsOfDoom.Core.Items
{
    public abstract class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
