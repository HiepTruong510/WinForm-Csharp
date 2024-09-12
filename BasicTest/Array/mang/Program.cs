using System;

namespace mang
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Doc va in cac phan tu trong C#:\n-------------------------------");
            int[] a = new int[20];
            Console.WriteLine("Nhap 10 phan tu mang:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - "+(i+1)+" : ");
                a[i]= Int32.Parse(Console.ReadLine()); 
            }
            Console.Write("Cac phan tu dao nguoc mang:");
            for(int i = 9; i >= 0 ; i--)
                Console.Write(" "+a[i]);
            
        }
    }
}
