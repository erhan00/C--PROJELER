using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("not gırınız");

            byte not;
            not = Convert.ToByte(Console.ReadLine());
           
            if(not < 50)
            {
                Console.WriteLine("basarısız");
                
                Console.WriteLine("butunleme notu");
                not = Convert.ToByte(Console.ReadLine());

                if(not < 50)
                {
                    Console.WriteLine("basarusız");
                }
                else
                {
                    Console.WriteLine("basarılı");
                }
            }
            else
            {
                Console.WriteLine("basarılı");
            }
            Console.ReadKey();
        }
    }
}
