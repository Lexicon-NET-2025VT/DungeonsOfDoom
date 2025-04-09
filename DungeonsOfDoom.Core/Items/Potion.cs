using DungeonsOfDoom.Core.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Items;
public class Potion() : Item("Potion")
{
    public override void PickUp(Player player)
    {
        player.Health += 5;
    }
}
