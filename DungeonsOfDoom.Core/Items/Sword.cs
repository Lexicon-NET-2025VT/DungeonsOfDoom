using DungeonsOfDoom.Core.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Items;
public class Sword() : Item("Sword")
{
    public override void PickUp(Player player)
    {
        player.Backpack.Clear();
        player.Health += 5;
    }
}
