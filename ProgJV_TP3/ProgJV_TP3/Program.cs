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
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int nbAleatoir = rnd.Next(1, 122);
                Console.WriteLine("nombre aleatoir : {0}", (nbAleatoir));
                Console.WriteLine("666");
            }
            for (int compteur = 1; compteur <= (rnd.Next(0, 200)); compteur++)
            {
                if (compteur < 100)
                {
                    Console.WriteLine("Première moitié");
                }
                if (compteur >= 120)
                {
                    Console.WriteLine("Deuxième moitié");
                }

                 Console.WriteLine(" ");
            }
            Console.WriteLine("Pwet");
            Console.ReadLine();
       }
    }
}
