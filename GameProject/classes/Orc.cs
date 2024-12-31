using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Orc : Monster
    {
        public string race { get; private set; }
        public Orc(int id, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, healthPoint, attackPoint, manager)
        {
            this.race = "Orc";
            Console.WriteLine($"[Orc] race: {race}");
        }
    }
}
