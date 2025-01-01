using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Slime : Monster
    {
        public string race { get; private set; }
        public Slime(int id, int healthPoint, int attackPoint, bool isBoss, string dropItem) : base(id, healthPoint, attackPoint, isBoss, dropItem)
        {
            this.race = "Slime";
            Console.WriteLine($"[Slime - 생성자] race: {race}");
        }

        public override void Attack(Combatant combatant)
        {
            base.Attack(combatant);
            Console.WriteLine($"[Npc - Attack] di: {this.id}");
        }
    }
}
