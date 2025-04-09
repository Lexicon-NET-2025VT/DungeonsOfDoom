using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom.Core.Creatures;
public record class AttackResult(Creature Attacker, Creature Opponent, int Damage);
