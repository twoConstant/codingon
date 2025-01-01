using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Player : Character
    {
        public int level { get; private set; }
        public List<string> quests { get; private set; } = new List<string>();

        public Player(int id, string name, int healthPoint, int attackPoint) : base(id, name, healthPoint, attackPoint)
        {
            this.level = 0;
            Console.WriteLine($"[Player - 생성자] level: {level}");
        }

        public void AddQuest(string quest)
        {
            this.quests.Add(quest);
            Console.WriteLine($"[Player - addQuest] 퀘스트 리스트 업로드 완료");
        }

        public override void Attack(Combatant combatant)
        {
            
            Console.WriteLine($"[Player - Attack] id: {this.id}, name: {this.name}");
        }
    }
}
