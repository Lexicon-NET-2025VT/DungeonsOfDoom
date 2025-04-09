namespace DungeonsOfDoom.Core.Creatures;

abstract public class Monster : Creature
{
    public static int MonsterCounter { get; private set; }
    public override int Health { get => base.Health;
        set
        {
            base.Health = value;

            if (!IsAlive)
                MonsterCounter--;
        }
    }

    public Monster(string name, int health) : base(name, health)
    {
        MonsterCounter++;
    }
}
