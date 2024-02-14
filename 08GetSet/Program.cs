using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
           // p.Name; to use the Getter
            p.Name = "John"; // to use the Setter
            Console.WriteLine(p.Name);
        }
    }
}