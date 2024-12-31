using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Player : Character
    {
        public int level { get; private set; }
        public List<string> quests { get; private set; } = new List<string>();

        public Player(int id, string name, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, name, healthPoint, attackPoint, manager)
        {
            this.level = 0;
            Console.WriteLine($"[Player] level: {level}");
        }

        public void addQuest(string quest)
        {
            this.quests.Add(quest);
            Console.WriteLine($"[Player - addQuest] 퀘스트 리스트 업로드 완료");
        }
    }
}
