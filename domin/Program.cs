using System ;
using System.Runtime.InteropServices;

namespace domin 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int input,input2;  
             //create map 
             String[,] Map = new String[10, 10];
            for (int i =0 ;i <8;i++)
            {
                for (int j =0;j<8;j++)
                {
                    if (i==0)
                    {
                        Map[i,j]=" "+j+" ";
                    }
                    else 
                    {
                        if (j==0)Map[i,j]=" "+i+" ";
                        else Map[i,j]=" X ";
                    }
                }
            }
            //toa do boom
            // string[] bom = new string[10];
            // bom[0]=Map[1,2];
            // bom[1]=Map[2,5];
            // bom[2]=Map[5,4];
            // bom[3]=Map[6,4];
            // bom[4]=Map[6,9];
            // bom[5]=Map[1,2];
            // bom[6]=Map[1,2];
            // bom[7]=Map[1,2];
            // bom[8]=Map[1,2];
            // bom[9]=Map[1,2];
            // xuat ra map 
            do 
            {
                for (int i =0 ;i < 7;i++)
                {
                    for (int j =0;j<8;j++)
                    {
                        Console .Write(Map[i,j]);
                    }
                    Console.WriteLine("");
                }
                Console.Write("chon toa do theo cu phap : ");
                input=Int32.Parse(Console.ReadLine());
                input2=Int32.Parse(Console.ReadLine());

                Console.Clear();
            } while (input!=0);        
        }
    }
}