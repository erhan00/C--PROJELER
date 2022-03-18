using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matrıslerde toplama");

            int[,] matris1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matris2 = { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };

            int[,] toplam = new int[3, 3];

            for(int a =0; a<3; a++ )
            {
                for(int b= 0; b<3; b++)
                {
                    toplam[a,b] = matris1[a, b] + matris2[a, b]; 
                }
            }

            for(int g = 0; g<3; g++)
            {
                Console.WriteLine();
                for(int r = 0; r<3; r++)
                {
                    Console.Write(toplam[g, r] + " ");
                }
            }
            Console.Read();
        }
    }
}
