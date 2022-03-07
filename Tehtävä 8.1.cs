using System;

namespace Tehtävä_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Tehtävä on 8.1");
            Console.WriteLine();
            Console.Write("---------------------");
            Console.WriteLine();
            Console.Write("Montako hedelmää haluat nähdä 1-3 ? ");
            //tässä luku esittää monta hedelmää käyttäjä haluaa nähdä
            luku = int.Parse(Console.ReadLine());
            //Hedelmät mitä on
            string[] nimet = { "Omena", "Banaani", "Luumu" };
            //kone on nolla, käyttäjä sitä ei tiedä vaan hän aloittaa ykkösestä
            //siksi i=0:lla; ja i:llä pitää olla pienempi(<)tai yhtäsuuri(=) kun käyttäjän
            //antama hedelmien määrä(luku)josta vähenetään yksi(-1) koska kone on o:lla.
            for (int i= 0; i <= luku -1; i++)
            {
                Console.WriteLine(nimet[i]);

            }
           

           


        }
    }
}
