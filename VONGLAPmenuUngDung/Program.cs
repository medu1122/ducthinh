using System;
namespace Menu 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int z;
            do 
            {
                Console.WriteLine("click 1 to Draw the triangle ");
                Console.WriteLine("click 2 to Draw the square ");
                Console.WriteLine("click 3 to Draw the rectangle");
                Console.WriteLine("click 0 to exit");
                Console.Write("ur choice : ");
                z=Int32.Parse(Console.ReadLine());
                if (z>0||z<4)
                {
                    switch (z)
                    {
                        case 1 : 
                            Console.WriteLine("Draw the triangle");
                            Console.WriteLine("* * *");
                            Console.WriteLine("**");
                            Console.WriteLine("*");
                            break;
                        case 2 :
                            Console.WriteLine("* * *");
                            Console.WriteLine("* * *");
                            Console.WriteLine("* * *");
                            break;
                        case 3 :
                            Console.WriteLine("* * * * * ");
                            Console.WriteLine("* * * * * ");
                            Console.WriteLine("* * * * * ");
                            break;
                        case 0 :
                            Environment.Exit(0);
                            break;
                        default :
                            Console.WriteLine("wrong");
                            break;
                    }
                }
            }
            while (z!=0);
        }
    }
}