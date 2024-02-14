using System;

class Student
{
    public string name;
    public double grade1, grade2;
    public double everageGrade;
    public string resultGrade;


    //Everage grade
    public double everage() 
    {
        everageGrade = (grade1 + grade2) / 2;
        return everageGrade;
    }

    //Conditions
    public string result(double everageGrade)
    {
        resultGrade = everageGrade >= 7 ? "Approved" : "Failed";
        return resultGrade;
    }

    //Message

    public void message()
    {

        double getEverageGrade = everage();
        string getResult = result(getEverageGrade);

        if (getEverageGrade >= 7)
        {
            Console.WriteLine(name+ ", you are "+getResult+". Your final grade is "+getEverageGrade+". Congratulations!");
        }
        else 
        {
            Console.WriteLine(name+ ", you "+getResult+". Your final grade is "+getEverageGrade+". Study more next time!");
        }
  
    }
}