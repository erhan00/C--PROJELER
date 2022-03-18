using System;

namespace mettott
{
    class Program

    { 

        // nesne tureterek metodun ozellıgının nesneye aktarılarak kullanımı.

        static void Main(string[] args)
        {
            metotlr metot1 = new metotlr();

            int sonuc = metot1.topla(3, 4);

            Console.WriteLine("sonucc : {0} ", sonuc);

            Console.ReadKey();

        }

        class metotlr
        {
            public int topla(int a, int b)
            {
                return (a + b);

            }
        }

        
    }
}
