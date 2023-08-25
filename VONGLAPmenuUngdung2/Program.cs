using System;
using System.Globalization;

namespace Menu 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int z;
            do 
            {
                Console.WriteLine("click 1 to Draw the right triangle ");
                Console.WriteLine("click 2 to Draw the square ");
                Console.WriteLine("click 3 to Draw the isosceles triangle");
                Console.WriteLine("click 0 to exit");
                Console.Write("ur choice : ");
                z=Int32.Parse(Console.ReadLine());
                if (z>0||z<4)
                {
                    switch (z)
                    {
                        case 1 : 
                            //for ve tam giac 
                            for(int i=3;i>=0;i--) 
                            {
                                for (int j=i;j<=3&&j>=0;j++)
                                {
                                    Console.Write(" * ");
                                }
                                Console.WriteLine("");
                                
                            }
                            //-----------
                            break;
                        case 2 :
                            //----------------------
                            for(int i=0;i<=3;i++)
                            {
                                for (int j=0;j<=3;j++)
                                {
                                    Console.Write(" * ");
                                }
                                Console.WriteLine("");
                            }
                            //----------------------
                            break;
                        case 3 :
                        // 
                            int k=4;
                            int h=4;
                            for (int i=1;i<=4;i++) 
                            {
                                
                                for (int j=1;j<=7;j++)
                                {
                                    if (i==4)
                                    {
                                        Console.Write(" * ");
                                    }
                                    else 
                                    {
                                        if(j>=k&&j<=h) 
                                        {
                                            Console.Write(" * ");
                                        }
                                        else 
                                        {
                                            Console.Write("   ");
                                        }
                                    }
                                }
                                Console.WriteLine("");
                                k=k-1;
                                h=h+1;
                            }
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