using System;

class Person 
{

    public string name;
    public int age;

    //Method 01
    public void display() //it's possible to have methods with the same name but it's required to have different parameters
    {
        Console.WriteLine("Hello "+name);
    }

    //Method 02
     public void display(string name)
    {
        Console.WriteLine("Hello "+name);
    }

    //Method 03
     public void display(string name, int age)
    {
        Console.WriteLine("Hello " +name+" your age is "+age+"");
    }

}