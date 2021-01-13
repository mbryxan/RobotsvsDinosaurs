using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Battlefield

    {
        //member variables

        List<Robot> robots;
        List<Dinosaur> dinosaurs;

        //and Choose a Dinosaur from the list

        //member constructor
        public Battlefield()
        {
            robots = new List<Robot>();
            Robot robotOne = new Robot("Tom", 2000, 50);
            Robot robotTwo = new Robot("John", 1500, 200);
            Robot robotThree = new Robot("Barry", 2000, 300);

            robots.Add(robotOne);
            robots.Add(robotTwo);
            robots.Add(robotThree);

            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaurOne = new Dinosaur("TRex", 2000, 25, 300);
            Dinosaur dinosaurTwo = new Dinosaur("Brontosaurus", 1500, 25, 200);
            Dinosaur dinosaurThree = new Dinosaur("Plateosaurus", 2000, 25, 300);

            dinosaurs.Add(dinosaurOne);
            dinosaurs.Add(dinosaurTwo);
            dinosaurs.Add(dinosaurThree);

        }
}
    //member method

        public void RunBattle()
        {
        //SELECT ROBOT:

            Console.WriteLine("Welcome to Dinos vs. Robots. To begin, choose a Robot from this list: " + " "); //Need: to access list of Robots
            Console.ReadLine();
            Console.WriteLine("Please choose a weapon for the robot to use against the Dinosaur from the list: " + " "); //Need: to access list of weapons
            Console.ReadLine();
         
        //SELECT DINOSAUR:

            Console.WriteLine("Please choose a dinosaur from this list:  " + " "); //Need to access list of Dinosaurs
            Console.ReadLine();
            Console.WriteLine("Please choose an attack type for the dinosaur"); //Need to access list of attack types
            Console.ReadLine();

        //BATTLE
            //Robot's Turn- Robot attacks Dinosaur
            //AttackDinosaur(); -------------- CHECK CODE
            //Reduce the health of the dinosaur by the hit from the amount of the robotWeaponAttackPower
            //

            //Reduce the robotAttackPower of the robot by -10 (bonus)
            //Print out "The robot hit the dinosaur and reduces the dinosaur's health by " ". The dinosaur now has " " health. The robot also has its attack power reduced by " ".
            //If the robots health is > 0 and the dinosaur's health is > 0, continue the fight
             if (robotHealth > 0 && dinosaurHealth > 0)
                    { Console.WriteLine(" The Robot")
                        

            //If the robots health is < = 0, print out "The Dinosaur has won!" and end the fight
                robotHealth <= 0 && dinosaurHealth < 0>
                Console.WriteLine("The Dinosaur has won!");
            //Else "print the battle will continue" and go to Dinosaur's turn
                else
            {
                Console.WriteLine("The battle rages on!");
            

            //Dinosaur's Turn 
            //Have dinosaur attack the robot (take a turn)
            //Reduce the health of the robot by the hit from the attack power of the dinosaurAttackPower
            //Reduce the dinosaurAttackPower of the dinosaur by -10 (bonus)
            //If the dinosaur's health is > 0 and tthe robot's health is > 0, continue the fight
            //If the dinosaur's health is <= 0, print "The Robot has won!"; end fight
            //If the robot's health is <=0, print "The dinosuar has won!"; end fight
            //Idea: create a loop and decrement the health of each robot and dinosaur after turn**?
        
        }
    }
}
