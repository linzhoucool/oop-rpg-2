using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{


    public class Shop
    {

       

        public Shop(Game game){

            
            this.Game = game;
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
            this.Potions = new List<Potion>();



            this.AddWeapons((1),"longSword",10, 2, 3);
            this.AddWeapons((2), "Axe Sword", 10, 6, 7);
            this.AddWeapons((3), "DIckk", 3, 5, 8);


            this.AddArmors("Wooden Armor", 2, 10, 2, 3);

            this.AddArmors("bigSword", 3, 20, 5, 7);

            this.AddPotions("lolSword", 4, 5, 5, 2);

        }


        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armors { get; set; }
       public  List<Potion> Potions { get; set; }
         public Game Game { get; set; }
        Item item { get; set; }
        public int number { get; set; }
        public Hero hero { get; set; }
        public string Name { get; set; }
        public string OriginalValue { get; set; }



        public void AddWeapons( int number, string name, int strength, int originalValue, int resellValue)
        {
            var weapons = new Weapon( number , name, strength, originalValue, resellValue);

            this.Weapons.Add(weapons);
        }



        public void AddArmors(string name, int number, int originalValue, int resellValue, int strength)
        {

            var armors = new Armor(name, number, strength, originalValue, resellValue);

            this.Armors.Add(armors);
        }


        public void AddPotions(string name, int number, int originalValue, int resellValue, int strength)
        {

            var potions = new Potion(name, number, strength, originalValue, resellValue);

            this.Potions.Add(potions);
        }
        



        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1) Buy Item");
            Console.WriteLine("2) Sell Item");
            Console.WriteLine("3) Return to Game Menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyFromUser();
            }
            else if (input == "3")
            {
              this.Game.Main();
            }
        }

        public void ShowInventory()
        {

            Console.WriteLine("WEAPONS SHOP");

           
            for (var number = 0; number < this.Weapons.Count(); number++)
            {
                Console.WriteLine("Reply any buttom");
                Console.WriteLine($"{Weapons[number].Number} | {Weapons[number].Name} | {Weapons[number].OriginalValue+"$"}");
               Console.ReadLine();
            }



            Console.WriteLine("Press NEXT to see ARMORS SHOP");
            Console.ReadLine();


            Console.WriteLine("ARMORS SHOP");
            Console.ReadLine();
            for (var number = 0; number < this.Armors.Count(); number++)
            {

                Console.WriteLine($"{this.Armors[number]} + {this.Armors[number].Name} + {this.Armors[number].OriginalValue + "$"}");
                Console.ReadLine();
            }


            


            Console.WriteLine("POTIONS SHOP");
            for (var number = 0; number < this.Potions.Count(); number++)
            {

                Console.WriteLine($"{this.Potions[number]} + {this.Potions[number].Name} + {this.Potions[number].OriginalValue + "$"}");
                Console.ReadLine();
            }

            Console.WriteLine("Please press r to return");
            Console.WriteLine("Please enter a number");

            var output = int.TryParse(Console.ReadLine(), out int result);
            if (output)
            {
                Console.WriteLine("please pick");
                this.SellFromUser(number);
            }
            else
            {
                Console.WriteLine("Please press any key to return to  main menu");
                Console.ReadLine();
                this.Game.Main();
            }
        }



        public void BuyFromUser()
        {
            Console.WriteLine("Sell Weapons");
            for (number = 0; number < this.Weapons.Count(); number++)
            {
                Console.WriteLine(this.Weapons[number].Name + " has resell value " + this.Weapons[number].ResellValue);

                

            }

            Console.WriteLine("Sell Armors");
            for (number = 0; number < this.Armors.Count(); number++)
            {
                Console.WriteLine(this.Armors[number].Name + " has resell value " + this.Armors[number].ResellValue);

               
            }


            Console.WriteLine("Sell Potion");
            for (number = 0; number < this.Potions.Count(); number++)
            {
                Console.WriteLine(this.Potions[number].Name + " has resell value " + this.Potions[number].ResellValue);

                this.Game.Main();
                Console.WriteLine("Please press r to menu");
                Console.WriteLine("Please type a number");

            }


            var type = int.TryParse(Console.ReadLine(), out int result);
            if (result == number)
            {
                this.SellFromUser(number);
            }
            else
            {
                Console.WriteLine("please press any key return to main menu");
                this.Menu();
            }

        }


            public void SellFromUser(int number)
         {
            Console.WriteLine("remove item");
            return;

        }





        public void Sell()
        {

            if (hero.Gold >= item.OriginalValue)
            {
                Console.WriteLine(hero.Gold = hero.Gold - Weapons[number].OriginalValue);
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy weapon");
                return;
            }
            Console.ReadLine();

        }















    }
}
