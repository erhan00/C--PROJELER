using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı, toplam = 0, adet = 0;
            sayı = Convert.ToInt32(Console.ReadLine());

            for (sayı = 1; sayı <= 1000; sayı++)
               
            {
                if((sayı % 5 == 0) && (sayı % 7 != 0))
                {
                    Console.WriteLine(sayı);
                    toplam += sayı;
                    adet++;

                }
            }
            Console.WriteLine("{0}sayı adetı", adet);
            Console.WriteLine("toplamları ={0}", toplam);
            Console.ReadKey();
        }
    }
}
