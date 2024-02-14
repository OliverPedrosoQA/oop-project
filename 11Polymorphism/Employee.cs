using System;

class Employee : Taxes
{
    //the foodVoucher methods is referenced from Taxes class, and for manager and employee the calculation is different, so the keyword override is added to the method.
       public override void foodVoucher(double salary)
    {
        Console.WriteLine("Employee food voucher value $: "+ (salary * 0.12));
    }
}