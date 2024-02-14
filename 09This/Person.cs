using System;

class Person
{
    private string name = "Paul"; //attribute name

    public Person(string name)
    {
        Console.WriteLine(name); //"name" is a parameter and the value is from the refereced constructor from Program class
        Console.WriteLine(this.name); //this is the attribute "name" from the same Person class
    }
}