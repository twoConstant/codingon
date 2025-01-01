using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.classes;

namespace GameProject.util
{
    public class BattleSystem
    {

        private static BattleSystem _instance; // 싱글톤 인스턴스

        // 싱글톤 인스턴스 접근 프로퍼티
        public static BattleSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BattleSystem();
                }
                return _instance;
            }
        }

        // 몬스터 vs Npc or Player
        public void CharacterVsMonster(Combatant character, Combatant monster)
        {
            if(!(IsCharacter(character) && IsMonster(monster)))
            {
                throw new InvalidOperationException("캐릭터와 몬스터가 아닙니다.");
            }
            character.Attack(monster);
        }

        
        // 캐릭터 확인
        private bool IsCharacter(Combatant combatant)
        {
            if(combatant is Character character)
            {
                return true;
            }

            return false;
        }

        // 몬스터 확인
        private bool IsMonster(Combatant combatant)
        {
            if (combatant is Monster monster)
            {
                return true;
            }

            return false;
        }


    }

}
