using System;

namespace dızı_ornk
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 15;
            int[,] dizı = new int[val, val];

            for(int i = 0; i<val; i++)
                for(int j =0; j<val; j++)
                {
                    if(j ==i)
                    {
                        dizı[i, j] = 1;
                        dizı[i, val - j - 1] = 1;
                    }

                    if (i == val / 2)
                        dizı[i, j] = 1;
                    if (j == val / 2)
                        dizı[i, j] = 1;
                }
           for(int i=0; i<val; i++)
            {
                for(int j =0; j<val; j++)
                {
                    if (dizı[i, j] == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
