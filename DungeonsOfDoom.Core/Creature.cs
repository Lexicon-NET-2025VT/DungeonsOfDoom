using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core;
public class Creature
{
    public int Health { get; set; }
    public bool IsAlive => Health > 0;

    public Creature(int health)
    {
        Health = health;
    }
}
