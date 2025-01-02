// See https://aka.ms/new-console-template for more information
using GameProject.classes;
using GameProject.util;

CombatantManager<Combatant> combatantManager = CombatantManager<Combatant>.Instance;

// 게임 캐릭터 생성
Combatant player = combatantManager.CreatePlayer("용사", 100, 30);
Combatant npc = combatantManager.CreateNpc("운영자", 100000, 100);
Combatant slime = combatantManager.CreateSlime(30, 1, false, "슬라임 꼬리");
Combatant orc = combatantManager.CreateOrc(100, 20, false, "부러진 방망이");



// 배틀
BattleSystem battleSystem = BattleSystem.Instance;
battleSystem.CharacterVsMonster(player, slime);
battleSystem.CharacterVsMonster(npc, orc);

// Talk() overriding practice
player.Talk();
npc.Talk();
slime.Talk();
orc.Talk();

// LevelUp OverLoading practice
Player actualPlayer = (Player)player;
actualPlayer.LevelUp();
actualPlayer.LevelUp(10);
actualPlayer.LevelUp(20, 100);

//// 동적 생성
//Combatant player2 = combatantManager.Create<Player>("용사", 100, 30);
//Combatant npc2 = combatantManager.Create<Npc>("운영자", 100000, 100);
//Combatant slime2 = combatantManager.Create<Slime>(30, 1, false, "슬라임 꼬리");
//Combatant orc2 = combatantManager.Create<Orc>(100, 20, false, "부러진 방망이");

//battleSystem.CharacterVsMonster(player2, slime2);
//battleSystem.CharacterVsMonster(npc2, orc2);

//// Talk() overriding practice
//player2.Talk();
//npc2.Talk();
//slime2.Talk();
//orc2.Talk();

//// LevelUp OverLoading practice
//Player actualPlayer2 = (Player)player2;
//actualPlayer2.LevelUp();
//actualPlayer2.LevelUp(10);
//actualPlayer2.LevelUp(20, 100);


//if (player is Player actualPlayer)
//{
//    actualPlayer.LevelUp();
//    actualPlayer.LevelUp(10);
//    actualPlayer.LevelUp(20, 100);
//}
//else
//{
//    Console.WriteLine("player는 Player 타입이 아닙니다.");
//}
