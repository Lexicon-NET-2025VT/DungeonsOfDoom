using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Creatures
{
    public class Player : Creature
    {
        public const int MaxHealth = 30;

        public List<Item> Backpack { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public override int Health { get => base.Health; set => base.Health = Math.Min(value, MaxHealth); }
        
        public Player() : base("Player", MaxHealth)
        {
            Backpack = new List<Item>();
        }
    }
}
