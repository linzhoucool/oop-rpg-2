using System;
namespace OOP_RPG
{
    public class Armor
    {
        public Armor(string name,int number, int defense, int originalValue, int resellValue)
        {
            
            this.Name = name;
            this.Number = number;
            this.Defense = defense;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;

        }
        
        public string Name { get; set; }
        public int Number { get; set; }
        public int Defense { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
      
    }
}
