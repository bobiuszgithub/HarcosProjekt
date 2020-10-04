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

            foreach (Harcos item in harcosok)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
