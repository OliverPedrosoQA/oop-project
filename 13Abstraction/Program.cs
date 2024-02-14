using System;

namespace _13Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            NaturalPerson np =  new NaturalPerson();
            np.calculateSavings(1000, 0.1);
            np.loanFee(1000);

            LegalEntity le = new LegalEntity();
            le.calculateSavings(1000, 0.2);
            le.loanFee(1000);
            
        }
    }
}