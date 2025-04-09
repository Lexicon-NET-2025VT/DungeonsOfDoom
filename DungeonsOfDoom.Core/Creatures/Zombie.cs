using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Creatures;
public class Zombie : Monster
{
	public Zombie() : base("Zombie", 5)
	{
	}

    public override AttackResult Attack(Creature opponent, int damage = 5)
    {
        if (opponent.Health > Health)
            damage = 1;
        
        return base.Attack(opponent, damage);
    }
}
