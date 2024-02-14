using System;

class Person
{
    protected string name; //only this class can use this method, and the inheriting classes
    protected int age; 

    protected void messagePerson()
    {
        Console.WriteLine("Name: " +name);
        Console.WriteLine("Age: " +age);
    }


}