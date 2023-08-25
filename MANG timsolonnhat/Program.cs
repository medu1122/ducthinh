using System ;
namespace mang 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int a,a2;
            int []arr;
            do 
            {
                Console.Write("nhap so luong cho mang : ");
                a = Int32.Parse(Console.ReadLine());
                if (a >0 )
                {
                    Console.WriteLine(" nhap cac phan tu cho mang so nguyen ");
                    arr = new int [a];
                    for (int i=0;i<=a-1;i++)
                    {
                        Console.Write ("arr["+i+"] = ");
                        arr[i]=Convert.ToInt32(Console.ReadLine());
                    }             
                        Console.WriteLine(" 1 , TIM SO LON NHAT ");
                        Console.WriteLine(" 2 , TIM SO LE LON NHAT");
                        Console.WriteLine(" exit");
                        Console.Write(" lua chon : ");
                        a2 = Convert.ToInt32(Console.ReadLine());
                        switch (a2)
                        {
                            case 1 :
                                int check = arr[0];
                                for (int i=0;i<a;i++)
                                {
                                    if (check<arr[i])check=arr[i];
                                    
                                }
                                Console.WriteLine("so lon nhat : "+check);
                                break;
                            case 2 :
                                int check2 = arr[0];
                                for (int i=0;i<a;i++)
                                {
                                    if (check2<arr[i]&&arr[i]%2!=0)check2=arr[i];
                                    
                                }
                                Console.WriteLine("so le lon nhat : "+check2);
                                break;
                            default :
                                Console.WriteLine("bye");
                                break;
                        }
                    
                }
                else 
                {
                    Console.WriteLine("nhap lai ");
                }
            }
            while (a<0);

        }
    }
}