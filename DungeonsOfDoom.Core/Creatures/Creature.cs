using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Creatures;
public abstract class Creature
{
    public virtual int Health { get; set; }
    public bool IsAlive => Health > 0;
    public string Name { get; set; }

    public Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual AttackResult Attack(Creature opponent, int damage = 10)
    {
        opponent.Health -= damage;
        return new AttackResult(this, opponent, damage);
    }

    //public virtual (Creature Attacker, Creature Opponent, int Damage) AttackWithTupes(Creature opponent, int damage = 10)
    //{
    //    opponent.Health -= damage;
    //    return (this, opponent, damage);
    //}
}
