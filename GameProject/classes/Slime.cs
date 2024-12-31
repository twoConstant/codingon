using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Slime : Monster
    {
        public string race { get; private set; }
        public Slime(int id, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, healthPoint, attackPoint, manager)
        {
            this.race = "Slime";
            Console.WriteLine($"[Slime] race: {race}");
        }
    }
}
