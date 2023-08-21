using System;
namespace BMI 
{
    class Program 
    {
        public static void Main(string[] args)
        {
                //CrVAR
            double bmi;
            double height;
            double weight;

                //INPUT 
            Console.Write("height : ");
            height = float.Parse(Console.ReadLine());
            Console.Write("weight : ");
            weight = float.Parse(Console.ReadLine());

                //CalBMI
            bmi = weight / Math.Pow(height,2);
            bmi = Math.Round(bmi, 1);
                //OUTPUT
            Console.Write("BMI: "+ bmi);

            if (bmi < 18)
                Console.WriteLine("Underweight");
            else if (bmi < 25.0)
                Console.WriteLine("Normal");
            else if (bmi < 30.0)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
        }
    }
}