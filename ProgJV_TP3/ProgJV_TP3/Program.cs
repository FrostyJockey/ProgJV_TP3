using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgJV_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // message qui va afficher: "Aimes-tu les pommes?"
            string firstSentence = "Aimez-vous les pommes?";
            char[] motCoupe = firstSentence.ToCharArray();
            Thread.Sleep(1000);
            for (int compteur = 0; compteur < motCoupe.Length; compteur++)
            {
                Console.Write(motCoupe[compteur]);
                Thread.Sleep(50);
            }
            Console.ReadLine();
        }
    }
}
