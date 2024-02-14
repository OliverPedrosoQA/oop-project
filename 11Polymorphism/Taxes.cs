using System;

class Taxes 
{
    public virtual void foodVoucher(double salary) //Manager and Employee reference this method changing how it workds, and it's possible by adding the keyword "virtual" to the method 
    {
        Console.WriteLine("Standard food voucher value $: "+ (salary * 0.1));
    }

    public virtual void transportVoucher(double salary)
    {
        Console.WriteLine("Standard transport voucher value $: " + (salary * 0.06));
    }
}