using System;
namespace OOP_RPG
{
    public class Weapon
    {
        public Weapon(int number,string name,  int strength , int originalValue , int resellValue ) {
            this.Name = name;
            this.Strength = strength;
            this.Number = number;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public int Number { get; set; }



    }
}
