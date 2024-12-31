using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public class LivingEntity
    {
        public int id { get; private set; }
        public int healthPoint { get; private set; }
        public int attackPoint { get; private set; }

        // 생성자
        public LivingEntity(int id, int healthPoint, int attackPoint)
        {
            this.id = id;
            this.healthPoint = healthPoint;
            this.attackPoint = attackPoint;
            Console.WriteLine($"[LivingEntity] id: {id}, healthPoint: {healthPoint}, attackPoint: {attackPoint}");
        }

        public int reduceHealthPoint(int attackPoint)
        {
            this.healthPoint -= attackPoint;
            return this.healthPoint;
        }
    }
}
