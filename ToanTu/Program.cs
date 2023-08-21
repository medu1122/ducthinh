using System;
namespace DienTich
{
    class Program 
    {
        public static void Main(string[] args)
        {
            float height;
            float width;
            Console.Write("enter width : ");
            width =float.Parse(Console.ReadLine());
            Console.Write("enter height : ");
            height =float.Parse(Console.ReadLine());
            float area = height * width ;
            Console.WriteLine("area is : "+area);
        }
    }
}