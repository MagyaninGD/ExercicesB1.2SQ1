using System;

namespace Exercice2S2
{
    class Program
    {

        static char saisiePrix()
        {
            char answer;
            do
            {
                Console.WriteLine();
                Console.Write("Avez vous un prix à saisir? [O/N] ");
                answer = Console.ReadKey().KeyChar;
            } while (answer != 'O' && answer != 'N');
            return answer;
        }
        static void Main(string[] args)
        {
            float prix, total = 0;
            char reponse;
            string devise;

            Console.Write("Quelle est la devise utilisée : ");
            devise = Console.ReadLine();
            reponse = saisiePrix();

            while (reponse == 'O')
            {
                Console.WriteLine();
                Console.Write("Entrez un prix: ");
                prix = float.Parse(Console.ReadLine());
                total += prix;
                reponse = saisiePrix();
            }

            Console.WriteLine();
            Console.Write("Le total des prix est de " + total + " " + devise);
            Console.ReadLine();

        }
    }
}
