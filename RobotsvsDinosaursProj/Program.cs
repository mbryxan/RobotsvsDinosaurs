using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battle = new Battlefield();
            battle.RunBattle();

            ////instantiate three robot objects and three Dinosaur objects and assign the appropriate vaules to all the objects
            Robot robotOne = new Robot("Sam", 1000, 25, "Mace", 10);  
            Robot robotTwo = new Robot("Larry", 900, 15, "Sword", 40);
            Robot robotThree = new Robot("John", 950, 20, "Hammer", 20);


            Dinosaur dinosaurOne = new Dinosaur("Brontosaurus", 1000, 20, 30);
            Dinosaur dinosaurTwo = new Dinosaur("Trex", 1500, 12, 30);
            Dinosaur dinosaurThree = new Dinosaur("Plateosaurus", 1200, 15, 20);

            //robotOne.AttackDinosaur(dinosaurOne);
            //robotOne.AttackDinosaur(dinosaurTwo);
            //robotOne.AttackDinosaur(dinosaurThree);


        }
    }
}
