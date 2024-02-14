using System;

namespace _02Methods
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Person obj = new Person();
            obj.display();
            obj.display("Peter");
            obj.display("Peter", 25);
        }
                
    }
}