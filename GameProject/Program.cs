// See https://aka.ms/new-console-template for more information
using GameProject.classes;
using GameProject.interfaces;

Manager<LivingEntity> manager = Manager<LivingEntity>.Instance;
// 유저 생성
Character player = new Player(manager.size, "용사", 100, 10, manager);
manager.Add(player);
// 몬스터 생성
Monster orc = new Orc(manager.size, 200, 1, manager);
manager.Add(orc);
player.attack(orc.id);
orc.attack(player.id);

