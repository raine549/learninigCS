//random changes rahhhhhh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Constructors are *special methods* used to initialise objects !!!!!
// Constructors are called when an object of a class is created
// can be used to set initial values for fields

namespace OOP
{
    class RaceHorse
    {
        public string model; //create a field

        //create a class constructor for RaceHorse class
        public RaceHorse()
        {
            model = "mustang"; //this will be called when object created
        }

        static void MainMethodd()
        {
            RaceHorse Ford = new RaceHorse(); // model immediately set as "mustang"
            Console.WriteLine(Ford.model);
        }
    }


    // Constructors can also take parameters, which is used to initialise fields
    // You can have many parameters
    class RaceHorse2
    {
        public string model;
        public string colour;
        public int year;

        //create class constructor with parameter
        public RaceHorse2(string modelName, string modelColour, int modelYear)
        {
            model = modelName; //immediately sets model as modelName (what will be input)
            colour = modelColour; // field = parameter input
            year = modelYear;
     
        }

        public static void callThisMethod() //create new object //also can use main string args
        {
            RaceHorse2 Ford = new RaceHorse2("mustang", "red", 1969); //sets model to "mustang"
            Console.WriteLine(Ford.model + " " + Ford.colour + " " + Ford.year);
        }
    }

}
