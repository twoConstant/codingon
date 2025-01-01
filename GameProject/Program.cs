// See https://aka.ms/new-console-template for more information
using GameProject.classes;
using GameProject.util;

CombatantManager<Combatant> combatantManager = CombatantManager<Combatant>.Instance;

// 게임 캐릭터 생성
Player player = combatantManager.CreatePlayer("용사", 100, 30);
Npc npc = combatantManager.CreateNpc("운영자", 100000, 100);
Slime slime = combatantManager.CreateSlime(30, 1, false, "슬라임 꼬리");
Orc orc = combatantManager.CreateOrc(100, 20, false, "부러진 방망이");

// 배틀
BattleSystem battleSystem = BattleSystem.Instance;
battleSystem.CharacterVsMonster(player, slime);
battleSystem.CharacterVsMonster(npc, orc);
