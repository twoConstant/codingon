using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.classes
{
    public abstract class Combatant
    {
        public int id { get; protected set; }
        public int healthPoint { get; protected set; }
        public int attackPoint { get; protected set; }

        // 생성자
        public Combatant(int id, int healthPoint, int attackPoint)
        {
            this.id = id;
            this.healthPoint = healthPoint;
            this.attackPoint = attackPoint;
            Console.WriteLine($"[Combatant - 생성자] id: {id}, healthPoint: {healthPoint}, attackPoint: {attackPoint}");
        }

        // 메서드
        public abstract void Attack(Combatant combatant);

        public virtual void CoreAttack(int damage)
        {
            this.healthPoint -= damage;
        }

        public abstract void Talk();
    }
}
