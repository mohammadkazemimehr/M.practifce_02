using System;

namespace Write_non_duplicate_numbers

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("pleas Enter the number : ");
            string A1 = Console.ReadLine();
            Console.WriteLine("pleas Enter the number : ");
            string A2 = Console.ReadLine();
            string A3 = string.Empty;
            for(int j =0;j<A1.Length;j++)
            {
                if (A3.Contains(A1[j])==false)
                {
                    A3 += A1[j];
                }
            }
            for(int i=0;i<A3.Length;i++)
            {
                if(A2.Contains(A3[i])==false)
                {
                    Console.Write(A3[i]);
                }
            }
        }
    }
}
