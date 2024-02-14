using System;

class Product 
{
    /*
        Access modifiers:
        public: attributes and methods that are visible in any class
        private: attributes and methods that are visible only in the class it is created
        protected: attributes and methods that are visible only in the classes it is created or inherited
    */

    public string name;
    private double age;

    public global::System.Double Age { get => age; set => age = value; }

    public global::System.Double Age { get => age; set => age = value; }
}