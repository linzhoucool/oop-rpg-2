using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Hero
    {

         
        
        /*This is a Constructor.
        When we create a new object from our Hero class, the instance of this class, our hero, has:
        an empty List that has to contain instances of the Armor class,
        an empty List that has to contain instance of the Weapon class,
        stats of the "int" data type, including an intial strength and defense,
        original hitpoints that are going to be the same as the current hitpoints.
        */
        public Hero() {
            this.ArmorsBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.PotionsBag = new List<Potion>();

            this.Strength = 10;
            this.Defense = 10;
            this.OriginalHP = 30;
            this.CurrentHP = 30;
            this.Gold = 100;
            this.Speed = 10;
        }
        
        // These are the Properties of our Class.
        public int Gold { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Speed { get;set;}

        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public Potion HealedPotion { get; set; }

        public List<Armor> ArmorsBag { get; set;}
        public List <Weapon> WeaponsBag { get; set; }
        public List<Potion> PotionsBag { get; set; }
        //These are the Methods of our Class.
        public void ShowStats() {
            Console.WriteLine("*****" + this.Name + "*****");
            Console.WriteLine("Strength: " + this.Strength);
            Console.WriteLine("Defense: " + this.Defense);
            Console.WriteLine("Hitpoints: " + this.CurrentHP + "/" + this.OriginalHP);
            Console.WriteLine("Weapon:  " + this.Strength);
            Console.WriteLine("Speed:  " + this.Speed);
            Console.WriteLine("Armor:  " + this.Defense);
            Console.WriteLine("Potion:  " + this.CurrentHP);
        }
        
        public void ShowInventory() {
            Console.WriteLine("*****  INVENTORY ******");
            Console.WriteLine("Weapons: ");

            foreach(var w in this.WeaponsBag){
                Console.WriteLine(w.Name + " of " + w.Strength + " Strength");
            }
            Console.WriteLine("Armor: ");
            foreach(var a in this.ArmorsBag){
                Console.WriteLine(a.Name + " of " + a.Defense + " Defense");
            }

            Console.WriteLine("Potion: ");
            foreach (var p in this.PotionsBag)
            {
                Console.WriteLine(p.Name + " of " + p.HP + "HP");
            }
        }
        

        public void EquipWeapon() {
            if(WeaponsBag.Any()) {
                {
                    if (this.EquippedWeapon != null) ;
                }
                this.EquippedWeapon = this.WeaponsBag[0];
                this.Strength += this.EquippedWeapon.Strength;
            }
        }
        
        public void EquipArmor() {
            if(ArmorsBag.Any()) {
                this.EquippedArmor = this.ArmorsBag[0];
            }
        }

        public void HealPotion(){
            if (PotionsBag.Any())
            {
                this.HealedPotion = this.PotionsBag[0];
            }
        }

        
        internal void AddGold(int gold)
        {
            this.Gold += gold;
        }



















    }
}
