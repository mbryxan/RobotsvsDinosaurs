﻿using System;
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

        

        public Weapon (string weaponType, int weaponAttackPower)

        { 
        this.weaponType = weaponType;
        this.weaponAttackPower = weaponAttackPower;

        }

        // create a List of different weapons that the Robot can choose from

        

        //List<string> weapons = new List<string>();
        //weapons.Add("Mace");
        //weapons.Add("Hammer");
        //weapons.Add("Sword");
           
    }

    //assign that weapon that is chosen to the Robot

}
