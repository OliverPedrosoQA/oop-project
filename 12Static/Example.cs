using System;

class Example 
{

    public static string name = "Paul";
    public static void sum(int n1, int n2)
    { // the static keyword allws to use the sum() method in another class without creating the object (Example e = new Example())
    // the sum() method will be available anywhere in the project
        Console.WriteLine("The sum is " + (n1 + n2));
    }
}