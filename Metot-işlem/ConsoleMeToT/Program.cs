using System;

namespace ConsoleMeToT
{
    class Program
    {

        static int enbyk(int a, int b)

        {
            if (a > b)

                return a;
            return b;

        }

        static int enbyk2(int z, int f, int x)
        {
            return enbyk(z, enbyk(f, x));

            Console.Read();
        }



        static void Main(string[] args)
        {
            int sayı1, sayı2, sayı3;
            Console.WriteLine("sayıları gırın");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            sayı2 = Convert.ToInt32(Console.ReadLine());
            sayı3 = Convert.ToInt32(Console.ReadLine());

            int maxx = enbyk2(sayı1, sayı2, sayı3);

            Console.WriteLine("en byk sayı :{0}" , maxx);
        }
    }
}
