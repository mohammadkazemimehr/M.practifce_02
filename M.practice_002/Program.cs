using System;

namespace Country_and_capital
{
    class Program
    {
        static void Main()
        {
            string[,] M = { {"A","B","C","D","E"},
                            {"x","z","V","W","Q"},
                            {"A","B","C","","E"},
                            {"A","B","C","D",""}};
            int k = -1;
            for (int i=0; i<=M.GetLength(0)-1 ;i++)
            {
                for (int G = i+1; G < M.GetLength(0); G++)
                {
                    k = 0;
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        if (M[i, j] == M[G, j])
                        {
                            k++;
                        }
                        if (k == 5)
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                    }
                    if (k == 5)
                    {
                        break;
                    }
                }
                if (k == 5)
                {
                    break;
                }
                else if (i == M.GetLength(0)-1)
                {
                    Console.WriteLine("NO");

                }
            }
        }
    }
}
