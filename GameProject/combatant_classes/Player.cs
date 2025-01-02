using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class Player : Character
    {
        public int level { get; private set; }
        public int power { get; private set; }
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

        public override void Talk()
        {
            base.Talk();
            Console.Write($"{id}번 Player야 \r\n");
        }
        public void LevelUp()
        {
            Console.WriteLine($"[Player - LevelUp] 매개변수를 하나 이상 입력해야합니다.");
        }

        public void LevelUp(int newHealthPoint)
        {
            this.healthPoint = newHealthPoint;
            Console.WriteLine($"[Player - LevelUp(int)] Player healthPoint: {this.healthPoint}");
        }

        public void LevelUp(int newHealthPoint, int newPower)
        {
            this.healthPoint = newHealthPoint;
            this.power = newPower;
            Console.WriteLine($"[Player - LevelUp(int, int)] Player healthPoint: {this.healthPoint}, Player power: {this.power}");
        }
    }
}
