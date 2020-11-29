using System;
namespace Country_and_capital
{
    class Program
    {
        static void Main()
        {
            string[,] Country = { { "Iran", "France", "Germany","Iraq","" },
                                  {"Tehran","Paris","Berlin","Baqhdad","" } };
            string namecountry = Console.ReadLine();
            for(int i =0; i<Country.GetLength(1); i++)
            {
                if (Country[0,i]==namecountry)
                {
                    Console.WriteLine(Country[1, i]);
                    break;
                }
                else if (i==4)
                {
                    Console.WriteLine("The capital was not found");
                }
            }
        }
    }
}