using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Npc : Character
    {
        public string quest { get; private set; }
        public Npc(int id, string name, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, name, healthPoint, attackPoint, manager)
        {
            this.quest = "램덤 퀘스트";
        }
    }
}
