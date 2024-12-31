using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.interfaces;

namespace GameProject.classes
{
    public class Character : LivingEntity, ICombat
    {
        private readonly IManager<LivingEntity> manager;
        public string name { get; private set; }

        // 생성자
        public Character(int id, string name, int healthPoint, int attackPoint, IManager<LivingEntity> manager) : base(id, healthPoint, attackPoint)
        {
            this.name = name;
            this.manager = manager;
            Console.WriteLine($"[Character] name: {name}");

        }

        public int attack(int id)
        {
            // 해당 id가 캐릭터인경우
            LivingEntity entity = manager.FindById(id);
            if(entity is Monster monster) {
                // 여기서 자동으로 entity는 monster로 변경되어야한다.
                monster.attacked(this.attackPoint);
                Console.WriteLine($"[Character - attack] Character가 몬스터: {id}를 공격합니다.");
                return id;
            }

            throw new InvalidOperationException($"id: {id}는 몬스터가 아닙니다.");
        }

        public int attacked(int attackPoint)
        {
            base.reduceHealthPoint(attackPoint);
            Console.WriteLine($"[Character - attacked] Character(id: {this.id}) healthPoint: {healthPoint}");
            return base.healthPoint;
        }
    }
}
