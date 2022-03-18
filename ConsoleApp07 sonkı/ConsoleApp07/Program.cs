using System;

namespace ConsoleApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adsoyad = new string[3];
            int[] sınav1 = new int[3];
            int[] sınav2 = new int[3];
            int[] ort = new int[3];


            for (int i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Write(i + ".ogrencı ad :");

                adsoyad[i] = Console.ReadLine();

                Console.Write(i + ". sınav1 :");

                sınav1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + ".sınav2 :");

                sınav2[i] = Convert.ToInt32(Console.ReadLine());

                

                ort[i] = (sınav1[i]+ sınav2[i]) / 2;           
            }

            Console.Write("ogrencıad   sınav1   sınav2  ortalama");
            Console.WriteLine();

            for( int i = 0; i<3; i++)
            {
                Console.WriteLine(" " + adsoyad[i]+  "      " + sınav1[i]+ "       " + sınav2[i]+ "    "+  ort[i]);
            }
            Console.Read();
        
            
        }
    }
}
