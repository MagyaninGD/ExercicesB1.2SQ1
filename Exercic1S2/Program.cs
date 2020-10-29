using System;

namespace Exercice2S2
{
    class Program
    {
        /// <summary>
        /// Saisie d'un choix parmis 2 possibilités, avec contrôle de saisie
        /// </summary>
        /// <param name="message">Le message à afficher</param>
        /// <param name="choix1">Le premier choix disponible</param>
        /// <param name="choix2">Le deuxième choix disponible</param>
        /// <returns>Le choix de l'utilisateur</returns>
        static char saisie(string message, char choix1, char choix2)
        {
            char answer;
            do
            {
                Console.WriteLine();
                Console.Write(message + " [" + choix1 + "/" + choix2 + "] : ");
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
            reponse = saisie("Avez vous un prix à saisir ?",'O','N');

            while (reponse == 'O')
            {
                Console.WriteLine();
                Console.Write("Entrez un prix: ");
                prix = float.Parse(Console.ReadLine());
                total += prix;
                reponse = saisie("Avez vous un prix à saisir ?", 'O', 'N');
            }

            Console.WriteLine();
            Console.Write("Le total des prix est de " + total + " " + devise);
            Console.ReadLine();

        }
    }
}
