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
            
            if (a!=0&&b!=0)
            {
                Console.Write("X= -B/A ="+-b+"/"+a+" = "+ -b/a);
            }
            else 
            {
                if (b==0)
                {
                    Console.WriteLine("all x is solution!");
                }
                else if (a==0)
                {
                    Console.WriteLine("Nod solution!");
                }
            }
        }
    }
}