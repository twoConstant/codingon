using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.classes;

namespace GameProject.util
{
    public class CombatantManager<T> where T : Combatant
    {
        private static CombatantManager<T> _instance; // 싱글톤 인스턴스
        public List<T> list { get; private set; } = new List<T>();
        public int size { get; private set; }

        private CombatantManager()
        {
            size = 0;

        }

        // 싱글톤 인스턴스 접근 프로퍼티
        public static CombatantManager<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CombatantManager<T>();
                }
                return _instance;
            }
        }

        public Player CreatePlayer(string name, int healthPoint, int attackPoint)
        {
            Player player = new Player(size, name, healthPoint, attackPoint);
            Add(player as T);
            return player;
        }

        public Npc CreateNpc(string name, int healthPoint, int attackPoint)
        {
            Npc npc = new Npc(size, name, healthPoint, attackPoint);
            Add(npc as T);
            return npc;

        }

        public Orc CreateOrc(int healthPoint, int attackPoint, bool isBoss, string dropItem)
        {
            Orc orc = new Orc(size, healthPoint, attackPoint, isBoss, dropItem);
            Add(orc as T);
            return orc;

        }

        public Slime CreateSlime(int healthPoint, int attackPoint, bool isBoss, string dropItem)
        {
            Slime slime = new Slime(size, healthPoint, attackPoint, isBoss, dropItem);
            Add(slime as T);
            return slime;
        }


        public void Add(T combatant)
        {
            list.Add(combatant);
            size++;
            Console.WriteLine($"[CombatantManager - Add] 추가완료 size: {size}");
        }

        public Combatant FindById(int id)
        {
            // 인덱스 유효성 검사
            if (id > size)
            {
                throw new InvalidOperationException($"id: {id}, size: {size} 해당 id는 존재하지 않습니다.");
            }
            // 비어있는 경우
            if (list[id] == null)
            {
                throw new InvalidOperationException($"id: {id}의 item이 비어있습니다.");
            }

            return list[id];
        }

        public void Remove(Combatant item)
        {
            throw new NotImplementedException();
            size--;
        }

    }
}
