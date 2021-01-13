using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Weapon

    {
        //member variables
        public string weaponType;
        public int weaponAttackPower;

        //constructor

        public Weapon(string weaponType, int weaponAttackPower)

        {
            this.weaponType = weaponType;
            this.weaponAttackPower = weaponAttackPower;

        }

        //method can do
        //create a List of different weapons that the Robot can choose from
        public void RobotChooseWeapon()
        {

            List<string> weapons = new List<string>();
            weapons.Add("Death Ray 2000");
            weapons.Add("Explosive Sheep");
                
            weapons.Add("Sword");

        }
           
    }

    

}
