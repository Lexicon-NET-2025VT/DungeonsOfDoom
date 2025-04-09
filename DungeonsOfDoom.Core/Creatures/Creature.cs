using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Creatures;
public abstract class Creature
{
    public int Health { get; set; }
    public bool IsAlive => Health > 0;

    public Creature(int health)
    {
        Health = health;
    }

    public virtual void Attack(Creature opponent, int damage = 10)
    {
        opponent.Health -= damage;
    }
}
