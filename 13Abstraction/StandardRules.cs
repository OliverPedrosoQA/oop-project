using System;

abstract class StandardRules
{
    //Mandatory method, it can be public or protected
    public abstract void loanFee(double value); //it does not use curly braces because the rules will be described in the class that inherits this abstract class

    //Optional method
    public void calculateSavings(double value, double fee)
    {
        Console.WriteLine("Recent savings: " +(value * fee));
    }

}