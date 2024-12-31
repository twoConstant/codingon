using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Monster : LivingEntity, ICombat
    {

        private readonly IManager<LivingEntity> manager;
        // 생성자
        public Monster(int id, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, healthPoint, attackPoint)
        {
            Console.WriteLine($"[Monster] id: {id}");
            this.manager = manager;
        }

        public int attack(int id)
        {
            // 해당 id가 캐릭터인경우
            LivingEntity entity = manager.FindById(id);
            if (entity is Character character)
            {
                // 여기서 자동으로 entity는 monster로 변경되어야한다.
                character.attacked(this.attackPoint);
                Console.WriteLine($"[Monster - attack] Monster가 id: {id}를 공격합니다.");
                return id;
            }

            throw new InvalidOperationException($"id: {id}는 캐릭터가 아닙니다.");
        }

        public int attacked(int attackPoint)
        {
            base.reduceHealthPoint(attackPoint);
            Console.WriteLine($"[Monster - attacked] Monster(id: {this.id}) healthPoint: {healthPoint}");
            return base.healthPoint;
        }
    }
}

