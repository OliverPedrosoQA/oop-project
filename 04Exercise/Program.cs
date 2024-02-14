using System;

namespace _Exercise04
{
    class Program 
{
    static void Main(string[] args)
    {
        Person obj = new Person();
        obj.weight = 100;
        obj.height = 1.60;
        obj.bmiResultMessage();
    }
}
}