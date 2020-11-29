using System;

namespace Search_the_string
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("plaes Enter  string : ");
            string A1 = Console.ReadLine();
            Console.WriteLine("pleas Enter another string : ");
            string A2 = Console.ReadLine();
            if(A1.Contains(A2)==true)
            {
                Console.WriteLine(A1.IndexOf(A2[0]));
            }
            else
            {
                Console.WriteLine("-1");
            }           
        }
    }
}
