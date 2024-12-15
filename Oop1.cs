using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace OOP
//{
//    internal class Car
//    {
//        string colour = "red"; 

//        static void MainMethodHere()
//        {
//            Car myObj = new Car();
//            Car myObj2 = new Car();
//            Console.WriteLine(myObj.colour);
//            Console.WriteLine(myObj2.colour);
//        }
//    }

//    //use the class to create objects

//    //you can also create an object of a class and access it in another class
//    // (typically, one class has all fields and methods, while the other holds the Main() method (code to be executed)


//    class CarClass
//    {
//        public string colour = "red"; //public so accessible in other classes
//    }

//    class Program
//    {
//        //main method here but im not going to
//        static void MainMethod()
//        {
//            CarClass myObj = new CarClass();
//            Console.WriteLine(myObj.colour);
//        }
//    }



//    //fields (variable within classes) and methods inside classes are "Class Members"

//    //you can access fields by creating and object of the class (and dot syntax)
//    //(as shown above)

//    //can also create multiple objects of a class

//    class Bike
//    {
//        string model;
//        string colour;
//        int year;

//        static void FakeMainMethod()
//        {
//            Bike Ford = new Bike();
//            Ford.model = "mustang";
//            Ford.colour = "red";
//            Ford.year = 1969;

//            Bike Opel = new Bike();
//            Opel.model = "Astra";
//            Opel.colour = "white";
//            Opel.year = 2005;

//            Console.WriteLine("Ford.model");
//        }

//        //Console.WriteLine(Ford.model); doesnt work here
//    }

//    class Car4
//    {
//        string colour; //field
//        public void fullThrottle() //method
//        {
//            Console.WriteLine("The car is going as fast as it can");
//        }
//        //method must be public to access / call it

//        static void fakeMainMethodAgain()
//        {
//            Car4 myObj = new Car4();
//            myObj.fullThrottle();
//        }


//    }



//}
