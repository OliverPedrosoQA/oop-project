using System;

namespace _03Exercise 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.name = "Paul";
            obj.grade1 = 2;
            obj.grade2 = 7;
            obj.message();
        }
    }
}