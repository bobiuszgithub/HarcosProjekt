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

            Console.WriteLine("adja meg a harcos nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("adja meg a státusz sablont(1/2/3)");
            int statusz = Convert.ToInt32(Console.ReadLine());

            var karakter = new Harcos(nev, statusz);
            harcosok.Add(karakter);

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
            char valasz;
            Console.WriteLine("mit szeretne csinálni? \na.) Megküzdeni egy harcossal\nb.) Gyógyulni\n c.) Kilépni");
            valasz = Convert.ToChar(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
