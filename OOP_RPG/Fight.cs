using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        //set the Monster property
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }

        public Fight(Hero hero, Game game)
        {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;

            this.AddMonster("Superman", 9, 8, 20 ,22 , 10);
            this.AddMonster("niuzhanshi", 11, 10, 10 , 20, 8);
            this.AddMonster("Ironman", 3, 6, 16, 17, 9);
            this.AddMonster("USAcaptain", 1, 8, 10, 100,7);


            //var the four monster attack attribute
            var enemy1 = this.Monsters.Last();

            var enemy2 = this.Monsters[0];

            var enemy3 = (from p in this.Monsters where p.CurrentHP < 20 select p).First();
            var enemy4 = (from p in this.Monsters where p.Strength >= 11 select p).First();

            //set the random monster fight
            var randomFight = Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();

            monster = randomFight;

        }

        public void AddMonster(string name, int strength, int defense, int hp, int gold , int speed)
        {
            var monster = new Monster(name, strength, defense, hp);
            this.Monsters.Add(monster);
        }

        public void Start()
        {


            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" +
            monster.CurrentHP + " HP/" +   "Gold/" + monster.Gold+  " What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn();
            }
            else
            {
                this.game.Main();
            }
        }

        public void HeroTurn()
        {
            var enemy = monster;
            var compare = hero.Strength - monster.Defense;
            int damage;

            if (compare <= 0)
            {
                damage = 1;
                enemy.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                enemy.CurrentHP -= damage;
            }
            Console.WriteLine("You did " + damage + " damage!");

            if (enemy.CurrentHP <= 0)
            {
                this.Win();
            }
            else
            {
                this.MonsterTurn();
            }

        }

        public void MonsterTurn()
        {
            var enemy = monster;
            int damage;
            var compare = enemy.Strength - hero.Defense;
            if (compare <= 0)
            {
                damage = 1;
                hero.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                hero.CurrentHP -= damage;
            }
            Console.WriteLine(enemy.Name + " does " + damage + " damage!");
            if (hero.CurrentHP <= 0)
            {
                this.Lose();
            }
            else
            {
                this.Start();
            }
        }

        public void Win()
        {
            var enemy = monster;
            hero.Gold = hero.Gold + enemy.Gold;
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle! You gain these money:" + enemy.Gold);
            Console.WriteLine("Hero got :$"+ hero.Gold);
            game.Main();
        }

        public void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }

    }

}
