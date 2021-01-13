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
        List<Dinosaur>dinosaurs;
        //string[] attackType;

        //member constructor

        public Herd ()
        {
            //instantiate the list of dinosaurs
            dinosaurs = new List<Dinosaur>();
            Dinosaur dinosaurOne = new Dinosaur("TRex", 2000, 25, 300); //create a new object(or individual dinosaur)
            Dinosaur dinosaurTwo= new Dinosaur("Brontosaurus", 1500, 25, 200); //create a new object(or individual dinosaur)
            Dinosaur dinosaurThree = new Dinosaur("Plateosaurus", 2000, 25, 300); //create a new object(or individual dinosaur)

            dinosaurs.Add(dinosaurOne); //adds first dinosaur to the list
            dinosaurs.Add(dinosaurTwo); //adds second dinosaur to the list
            dinosaurs.Add(dinosaurThree); //adds third dinosaur to the list
        }

        //member methods- what it can do
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
