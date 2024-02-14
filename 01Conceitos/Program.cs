using System;

namespace _01Conceitos 
{ //this is the folder where the project is located

    class Program {
        static void Main(string[] args) { //every file has one of this function to execute the commands from inside 
           
           //Referencing Object from Person.cs file
           Person obj = new Person();
           obj.name = "Oliver";
           obj.age = 29;
           obj.message();

        }
    }
}

