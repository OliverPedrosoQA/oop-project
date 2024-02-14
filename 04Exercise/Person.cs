using System;

class Person 
{
    public double weight, height, bmi;

    //Body Mass Index calculation
    public double calculateBmi(double weight, double height)
    {
        bmi = Math.Round(weight / (height * height), 1);
        return bmi;
    }

    public string bmiResult(double bmi)
    {
        string bmiStatus;

        if (bmi <= 18.5)
        {
           bmiStatus = "Underweight";
        }
        else if (bmi <= 25)
        {
            bmiStatus = "Regular Weight";
        }
        else if (bmi <= 30)
        {
           bmiStatus = "Overweight";
        }
        else if (bmi <= 35)
        {
            bmiStatus = "Obesity I";
        }
        else if (bmi <= 40)
        {
            bmiStatus = "obesity II";
        }
        else 
        {
            bmiStatus = "Obesity III";
        }
        return bmiStatus;
    }


    public void bmiResultMessage()
    {
        double getBmi = calculateBmi(weight, height);
        string getBmiResult = bmiResult(getBmi);

        Console.WriteLine("Your Body Mass Index (BMI) is " + getBmi + " and your BMI status is " + getBmiResult);
    }
    
}