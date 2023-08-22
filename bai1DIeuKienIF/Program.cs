using System;
namespace PtrinhBac1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ax+B=0");
            Console.Write("enter A : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("X= -B/A ="+-b+"/"+a+" = "+ -b/a);
            
        }
    }
}