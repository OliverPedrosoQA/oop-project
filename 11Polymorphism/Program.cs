using System;

namespace _11Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //each class extends Taxes from a different object
            Taxes objectM = new Manager();
            objectM.foodVoucher(90000);
            objectM.transportVoucher(90000);
            Console.WriteLine("___________________________");

            Taxes objectE = new Employee();
            objectE.foodVoucher(40000);
            objectE.transportVoucher(40000);
            Console.WriteLine("___________________________");
            
            // Because the class Intern does not reference the methods, the calculation will be made from the mother class Taxes
            Taxes objectI = new Intern();
            objectI.foodVoucher(20000);
            objectI.transportVoucher(20000);
            Console.WriteLine("___________________________");                   
        }
    }
}