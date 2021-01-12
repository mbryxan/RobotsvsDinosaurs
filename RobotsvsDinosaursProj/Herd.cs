using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Herd
    {
        //Dinosaur created objects stored here

        //member variables
        List<Dinosaur> dinosaurs;
        //string[] attackType;

        //member constructor

        public Herd ()
        {
            //instantiate the list of dinosaurs
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaurOne = new Dinosaur("TRex", 2000, 25, 300);
            Dinosaur dinosaurTwo= new Dinosaur("Brontosaurus", 1500, 25, 200);
            Dinosaur dinosaurThree = new Dinosaur("Plateosaurus", 2000, 25, 300);

            dinosaurs.Add(dinosaurOne);
            dinosaurs.Add(dinosaurTwo);
            dinosaurs.Add(dinosaurThree);

        }

        //member methods- can do
        //create a list of attack types from an array that can be chosen by the dinosaur

        
        public void ChooseAttackType(Dinosaur dinosaur)

        {
            string[] attackTypeArray = new string[3];
            attackTypeArray[0] = "Thrash";
            attackTypeArray[1] = "Headbutt";
            attackTypeArray[2] = "Pounce";

        }
       

            
        

    }
}
