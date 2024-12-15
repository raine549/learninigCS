using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// access modifiers in c#:
// public - accessible for all classes
// private - only accessible within the same class
// protecte - accessible within same class, or a class inherited from that class
// internal - code only accessible within its own assembly, but not another assembly

// theres also 'protected internal' and 'private protected'

// by default, all members of a class are private !!


// Encapsulation - making sure that sensitive data is hidden from users
// done by: 
//   declaring fields / variables as private
//   provide 'public' 'get' and 'set' methods through 'properties' 
//   (in ordr to access and update the value of private field)


//PROPERTIES

/// private variables can obly by accessed within the same class
/// however, sometimes we need to access them, which can be done with properties
/// 
/// a property is like a combination of a variable and a method
/// it has two methods: 'get' and 'set' method
/// 

namespace OOP
{
    class Person
    {
        private string name; //field
        public string Name //property
        {
            get { return name; } //get method
            set { name = value; } //set method
        }
    }
    /// The 'Name' property is associated with the 'name' field
    /// (its a good practice to use same name for both but with uppercase)
    /// get returns the value of the variable name
    /// set assigns a value to name variable. value represents value we assign to the property.
    //now we can use the Name property to access and update the private field of the Person class


    //you can shorthand the above code
    class Person2
    {
        public string Name //property
        {
            get; set;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam"; //editing the property
            Console.WriteLine(myObj.Name);
        }
    }



}
