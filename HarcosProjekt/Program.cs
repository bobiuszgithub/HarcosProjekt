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


            char valasz;
            int kor = 0;
            int hanyadik;
            List<int> sorszamok = new List<int>();
            for (int i = 0; i < harcosok.Count; i++)
            {
                sorszamok.Add(i + 1);

            }

            do
            {
                kor++;
                Console.WriteLine("\n{0}.Kör\n", kor);

                for (int i = 0; i < harcosok.Count; i++)
                {
                    
                    Console.WriteLine("{0}. {1}", i + 1, harcosok[i]);

                }
                Console.WriteLine("\nmit szeretne csinálni? \na.) Megküzdeni egy harcossal\nb.) Gyógyulni\nc.) Kilépni");
                valasz = Convert.ToChar(Console.ReadLine());
                while (valasz != 'a' && valasz != 'b' && valasz != 'c')
                {
                    Console.WriteLine("\nmit szeretne csinálni? \na.) Megküzdeni egy harcossal\nb.) Gyógyulni\nc.) Kilépni");
                    valasz = Convert.ToChar(Console.ReadLine());
                }


                
                if (valasz == 'a')
                {
                    Console.WriteLine("Hányadik harcossal szeretne megküzdeni a listából?");
                    for (int i = 0; i < harcosok.Count; i++)
                    {
                        Console.Write("{0} ", i+1);
                    }
                    Console.WriteLine();
                    hanyadik = Convert.ToInt32(Console.ReadLine());

                    sorszamok.Remove(1);
                    while (!sorszamok.Contains(hanyadik))
                    {
                        Console.WriteLine("Hányadik harcossal szeretne megküzdeni a listából?");
                        hanyadik = Convert.ToInt32(Console.ReadLine());
                    }
                    harcosok[0].Megkuzd(harcosok[hanyadik-1]);

                }


            } while (valasz != 'c');

            Console.ReadLine();
        }
    }
}
