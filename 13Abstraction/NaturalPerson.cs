using System;

class NaturalPerson : StandardRules
{

    // This method is mandatory to be implemented, if it's commented it shows the error message
    public override void loanFee(double value)
    {
        Console.WriteLine("Loan fee for Natural Person $ " +(value * 0.1));
    }
}