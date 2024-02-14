using System;

class LegalEntity : StandardRules
{
    public override void loanFee(double value)
    {
        Console.WriteLine("Loan fee for Legal Entity $ " +(value * 0.2));
    }
}