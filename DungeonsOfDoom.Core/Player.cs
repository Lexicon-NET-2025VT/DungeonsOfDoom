namespace DungeonsOfDoom.Core
{
    public class Player
    {
        public const int MaxHealth = 30;
        public Player()
        {
            Health = MaxHealth;
            Backpack = new List<Item>();
        }

        public List<Item> Backpack { get; }
        public int Health { get; set; }
        public bool IsAlive => Health > 0;
        public int X { get; set; }
        public int Y { get; set; }
    }
}
