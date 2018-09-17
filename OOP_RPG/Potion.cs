using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Potion
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public int Number { get; set; }

        public Potion(string name, int number,int hp, int originalValue, int resellValue)
        {
            this.Number = number;
            this.Name = name;
            this.HP = hp;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;

        }
    }

}
