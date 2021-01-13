using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Fleet
    {   //robot created objects here

        //member variables
        List<Robot> robots;

        //member constructor
        public Fleet()
        {
            //instantiate the list of robots
            robots = new List<Robot>();
            Robot robotOne = new Robot("Tom", 2000, 50);
            Robot robotTwo = new Robot("John", 1500, 200);
            Robot robotThree = new Robot("Barry", 2000, 300);

            robots.Add(robotOne);
            robots.Add(robotTwo);
            robots.Add(robotThree);

        }

        //member methods

        //public void ChooseRobotFromHerd(Fleet fleet)
        //
        //    {
        //    List<string> robotChoices = new List<string>();
        //    robotChoices.Add("Tom");
        //    robotChoices.Add("John");
        //    robotChoices.Add("Barry");
        //    }
        
    }
}
