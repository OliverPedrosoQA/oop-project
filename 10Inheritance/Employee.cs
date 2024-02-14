using System;

class Employee : Person // the two dots "extends" the class Person to Employee
{
    private double compensation;

//  Constructor
    public Employee(string name, int age, double compensation)
    {
        this.name = name; //attributes from employee and person classes receive the values from the parameters. The parameters values are in the Person constructor referenced in the Program.cs file.
        this.age = age;
        this.compensation = compensation;

        messagePerson();
        messageEmployee();

    }

    //Method
    private void messageEmployee()
    {
        Console.WriteLine("Compensation: " +compensation);
    }
}