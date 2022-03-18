using System;

namespace ConsoleApp7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // bes elemanlı bır dızıde en buyuk elemanı bulup yazdıran prog.(kullanıcı gırecek)

            int[] byeleman = new int[5];
            int i;
            for ( i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ".sayıyı gırın");
                byeleman[i] = Convert.ToInt32(Console.ReadLine());    
            }
            int enbyk = byeleman[0];

            for (i = 1; i < 5; i++)
            {



                if (enbyk < byeleman[i])
                {
                    enbyk = byeleman[i];
                }
            }
            
            Console.Write(enbyk);
            Console.ReadKey();
        }
    }
}
