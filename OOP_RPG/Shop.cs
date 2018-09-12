using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{


    public class Shop
    {
        public List<Weapon> Weapons;
        public List<Armor> Armors;
        public List<Potion> Potions;


        public Shop()
        {

            Weapons.Add(new Weapon ("Blade Sword", 13, 800, 200 ));
            Weapons.Add(new Weapon("Magic Essence Orb", 12, 300, 100));
            Weapons.Add(new Weapon("Sea Stone Trident", 9, 1000, 200));

            Armors.Add(new Armor("BF sword", 15,188, 22));
            Armors.Add(new Armor("Gun of Kingnight", 17, 400, 222));
            Armors.Add(new Armor("Gun of Kingnight", 17, 400, 666));

            Potions.Add(new Potion("BF sword", 15, 888, 22));
            Potions.Add(new Potion("Gun of Kingnight", 17, 999, 888));

        }


    }




}