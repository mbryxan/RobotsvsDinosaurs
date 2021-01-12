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
        public int dinosaurWeaponAttackPower;

        //member constructor
        public Dinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergy, int dinosaurWeaponAttackPower)

        {
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergy = dinosaurEnergy;
            this.dinosaurWeaponAttackPower = dinosaurWeaponAttackPower;
        }

        //member methods--block of a code that runs when it's called (used) -  the actions of the class
        public void AttackRobot(Robot robot)
        //attack a Robot through a method called AttackRobot() and causes Robot health to decrease based on dinosaurWeaponAttackPower

        {
            robot.robotHealth -= dinosaurWeaponAttackPower;
        }
               
        public void ReduceAttackPower(Dinosaur dinosaur)
        //attack a Robot through a method called AttackRobot() and causes dinosaurAttackPpower to be reduced by 10
        //bonus point
        {
            dinosaur.dinosaurHealth -=10;
        }
    

    }
}
