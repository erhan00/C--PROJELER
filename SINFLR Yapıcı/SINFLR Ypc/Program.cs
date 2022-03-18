using System;

namespace SINFLR_Ypc
{
    class Program
    {
        static void Main(string[] args)
        {
            prog pproog1 = new prog { İd = 1, Fırstname = " erh",Lastname = "klkn" };

            Console.WriteLine(pproog1.Lastname,pproog1.Fırstname);

            prog pprg2 = new prog(2, "alı", "velı");

            Console.WriteLine( pprg2.Lastname);
        }
    }

    class prog
    {
        public prog()
        {

        }
        public prog(int id, string fırstname, string lastname)
        {
            İd = id;
            Fırstname = fırstname;
            Lastname = lastname;
        }

        public int İd;
        public string Fırstname;
        public string Lastname;
    }
}
