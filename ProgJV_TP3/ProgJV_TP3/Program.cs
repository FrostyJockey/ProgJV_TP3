using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgJV_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int compteur = 1; compteur <= 200; compteur++)
            {
                if (compteur < 100)
                {
                    Console.WriteLine("Première moitié");
                }
                if (compteur >= 100)
                {
                    Console.WriteLine("Deuxième moitié");
                }

            }
            Console.WriteLine("Pwet");
            Console.ReadLine();
        }
    }
}
