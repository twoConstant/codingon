using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Npc : Character
    {
        public string quest { get; private set; }
        public Npc(int id, string name, int healthPoint, int attackPoint) : base(id, name, healthPoint, attackPoint)
        {
            this.quest = "램덤 퀘스트";
            Console.WriteLine($"[Npc - 생성자] quest: {quest}");
        }

        public override void Attack(Combatant combatant)
        {
            base.Attack(combatant);
            Console.WriteLine($"[Npc - Attack] id: {this.id}, name: {this.name}");
        }

        public override void Talk()
        {
            base.Talk();
            Console.Write($"{id}번 Npc야 \r\n");
        }
    }
}
