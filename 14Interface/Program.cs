using System;

namespace _14Interface // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations c = new Calculations();
            c.sum(10, 15);
            c.subtraction(30, 12);
        }
    }
}