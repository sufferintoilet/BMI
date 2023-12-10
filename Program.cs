﻿using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
       double height;
       double weight;

       Console.WriteLine("Enter your height");
       height = float.Parse(Console.ReadLine());
       Console.WriteLine("Enter your weight");
       weight = float.Parse(Console.ReadLine());
       double bmi = weight / Math.Pow(height,2);
       bmi = Math.Round(bmi, 1);

       Console.Write("BMI: "+ bmi);

        if (bmi<18)
            Console.WriteLine("Underweight");
        else if (bmi<25)
            Console.WriteLine("Normal");
        else if (bmi<30)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");

    }
}