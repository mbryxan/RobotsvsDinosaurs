﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {
        //member variables-- creates/describes attributes 
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;


        //member constructor-- set the intial values for variables
        public Robot(string robotName, int robotHealth, int robotPowerLevel)

        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;

        }

        //member methods--block of a code that runs when it's called (used) -  the actions of the class-- what the Robot can do
        public void AttackDinosaur(Dinosaur dinosaur)
        //attack a Dinosaur through a method called AttackDinosaur () and causes robotAttackPower to be reduced by 10

        {
            dinosaur.dinosaurHealth -= robotPowerLevel;
            // ?????
        }

            //decrease by 10 the robotAttackPower every time it attacks
            //extra credit item       
        

}

        





        
        
}
