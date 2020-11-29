using System;

namespace Enter_in_the_string
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please Enter a string : ");
            string A1 = Console.ReadLine();
            Console.WriteLine("please entaer another string : ");
            string A2 = Console.ReadLine();
            string A3 = string.Empty;
            for(int i=A2.Length-1;i>-1;i--)
            {
                A3 += A2[i];
            }
            Console.WriteLine("please Enter a number : ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please nter another number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            string newN = string.Empty;
            for(int j=0;j<M;j++)
            {
                newN += A3[j];               
            }
            Console.WriteLine(A1.Insert(M, newN));
        }
    }
}
