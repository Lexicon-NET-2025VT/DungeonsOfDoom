using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Creatures
{
    public class Player : Creature
    {
        public const int MaxHealth = 30;

        public Player() : base(MaxHealth)
        {
            Backpack = new List<Item>();
        }

        public List<Item> Backpack { get; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
