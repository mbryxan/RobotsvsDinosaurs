﻿using System;
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



        //and Choose a Dinosaur from the list



        //member constructor


        //member method

        public void RunBattle()
        {




            //ROBOT MOVES:
            //Prompt user to choose from a list of robots that we've created to do battle 
            Console.WriteLine("Welcome to Dinos vs. Robots. Please choose which Robot you would like to use");
           //User chooses a robot from the list of Robots

        //Prompt user to choose a weapon for thee robot to use from the list
        //User is assigned a weapon from the list for the Robot

            //DINOSAUR MOVES:
            //Prompt user to choose from a list of dinosaurs that we've created to do battle
            //User chooses a dinosaur from the list
            //Prompt user to choose an attack type for the dinosaur from the array
            //User is assigned an attack type for the dinosaur

            //BATTLE
            //Robot's Turn
            //Have robot attack the dinosaur (take a turn)
            //Reduce the health of the dinosaur by the hit from the amount of the robotWeaponAttackPower
            //Reduce the robotAttackPower of the robot by -10 (bonus)
            //Print out "The robot hit the dinosaur and reduces the dinosaur's health by " ". The dinosaur now has " " health. The robot also has its attack power reduced by " ".
            //If the robots health is > 0 and the dinosaur's health is > 0, continue the fight
            //If the robots health is < = 0, print out "The Dinosaur has won!" and end the fight

            //Else "print the battle will continue" and go to Dinosaur's turn


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
