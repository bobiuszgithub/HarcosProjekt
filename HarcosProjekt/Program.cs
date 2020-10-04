using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //valamiért az iskolában egy másik diák nevével pusholta fel nekem
            //ezért inkább egy új repositoryt csináltam 


            List<Harcos> harcosok = new List<Harcos>();

            StreamReader r = new StreamReader("harcosok 1.csv");

            // harcosok.Add(new Harcos("Bob1", 1));
            // harcosok.Add(new Harcos("Bob2", 2));
            //  harcosok.Add(new Harcos("Bob3", 3));

            try
            {
                while (!r.EndOfStream)
                {
                    string[] s = r.ReadLine().Split(';');
                    harcosok.Add(new Harcos(s[0], Convert.ToInt32(s[1])));
                }

            }
            catch (Exception)
            {

                throw;
            }
            r.Close();

            for (int i = 0; i < harcosok.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, harcosok[i]);
            }


            Console.ReadLine();
        }
    }
}
