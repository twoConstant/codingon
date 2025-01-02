using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Orc : Monster
    {
        public string race { get; private set; }
        public Orc(int id, int healthPoint, int attackPoint, bool isBoss, string dropItem) : base(id, healthPoint, attackPoint, isBoss, dropItem)
        {
            this.race = "Orc";
            Console.WriteLine($"[Orc - 생성자] race: {race}");
        }

        public override void Attack(Combatant combatant)
        {
            base.Attack(combatant);
            Console.WriteLine($"[Orc - Attack] di: {this.id}");
        }

        public override void Talk()
        {
            base.Talk();
            Console.Write($"{id}번 Orc야 \r\n");
        }
    }
}
