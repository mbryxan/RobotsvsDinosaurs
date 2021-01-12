using System;
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
        public string robotWeaponType;
        public int robotAttackPower;
         
        //member constructor-- set the intial values for variables
        public Robot (string robotName, int robotHealth, int robotPowerLevel, string robotWeaponType, int robotAttackPower )

            {
        this.robotName = robotName;
        this.robotHealth = robotHealth;
        this.robotPowerLevel = robotPowerLevel;
        this.robotWeaponType = robotWeaponType;
        this.robotAttackPower = robotAttackPower;
            }

        //member methods--block of a code that runs when it's called (used) -  the actions of the class-- what the Robot can do
        public void AttackDinosaur(Dinosaur dinosaur)
        //attack a Dinosaur through a method called AttackDinosaur () and causes robotAttackPower to be reduced by 10

        {
            robotPowerLevel -= 10;
            
            //decrease by 10 the robotAttackPower every time it attacks
            //extra credit item       
        }

        public void ReceiveHitFromDinosaur(Dinosaur dinosaur)

        {

            //receives a hit from the Dinosaur through method called ReceiveHitFromDinosaur() and causes robotHealth to be reduced 

        }
            

        }


        // dinosaur.dinosaurHealth -=  10;
    }
}
