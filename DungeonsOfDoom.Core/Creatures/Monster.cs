namespace DungeonsOfDoom.Core.Creatures
{
    abstract public class Monster : Creature
    {
        public Monster(string name, int health) : base(health)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
