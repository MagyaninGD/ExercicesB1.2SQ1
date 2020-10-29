using System;

namespace Exercic1S2
{
    class Program
    {
        static char reponse;
        static void saisiePrix()
        {
            do
            {
                Console.WriteLine();
                Console.Write("Avez vous un prix à saisir? [O/N] ");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != 'O' && reponse != 'N');
        }
        static void Main(string[] args)
        {
            float prix , total = 0;
            string devise;

            Console.Write("Quelle est la devise utilisée : ");
            devise = Console.ReadLine();
            saisiePrix();

            while (reponse == 'O')
            {
                Console.WriteLine();
                Console.Write("Entrez un prix: ");
                prix = float.Parse(Console.ReadLine());
                total += prix;
                saisiePrix();
            }

            Console.WriteLine();
            Console.Write("Le total des prix est de " + total + " " + devise);
            Console.ReadLine();

        }
    }
}
