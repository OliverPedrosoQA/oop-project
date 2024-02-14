using System;

class Person
{
    private string name; //the atribute is private but it's possible to reference it from other files calling the get/set methods

    public string Name //the get/set method has the name of the attribute but with upper case
    {
        get{return name;} //these lines set the Getter and Setter of the "name" attribute
        set{name = value;}
    }
} 