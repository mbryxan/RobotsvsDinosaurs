using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string dinosaurType;
        public int dinosaurHealth;
        public int dinosaurEnergy;
        public int dinosaurAttackPower;

        //member constructor
        public Dinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergy, int dinosaurAttackPower)

        {
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergy = dinosaurEnergy;
            this.dinosaurAttackPower = dinosaurAttackPower;
        }

        //member methods--block of a code that runs when it's called (used) -  the actions of the class
        public void AttackRobot(Robot robot)
        //attack a Robot through a method called AttackRobot() and causes dinosaurAttackPpower to be reduced by 10

        {
            dinosaurAttackPower -= 10;
        }

        public void ReceiveHitFromRobot(Robot robot)
        //receives a hit from the Robot through method called ReceiveHitFromRobot() and causes dinosaurHealth to be reduced
        {
            dinosaurHealth =  (dinosaurHealth) - (robotPowerLevel);
        }


    }
}
