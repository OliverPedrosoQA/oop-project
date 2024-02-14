using System;

namespace _05Access
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Product();
            p.age = 10; //this should not be referenced
        }
    }
}