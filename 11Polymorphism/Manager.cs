using System;

class Manager : Taxes
{
    public override void foodVoucher(double salary)
    {
        Console.WriteLine("Manager food voucher value $: "+ (salary * 0.15));
    }

}