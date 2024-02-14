using System;

class Student 
{
    private double grade1, grade2;

    private double everage()
    {
       return (grade1 + grade2) / 2;
    }

    public void message()
    {
        Console.WriteLine("Input grade 1: ");
        grade1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input grade 2: ");
        grade2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your final grade is: " + everage());

    }
}