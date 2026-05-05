using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTOMLEVRAI
{
    internal class Program
    {
       static void Main(string[] args)
{
    Random random = new Random();

    string[] liste = {
        "ASPHYXIEZ", "HYDROXYDE", "PEROXYDEZ", "KAMIKAZES",
        "KLAXONNEZ", "HYPOPHYSE", "EXPLIQUEZ", "EXTORQUEZ",
        "EFFRAYIEZ", "FOURVOYEZ", "FLAMBOYEZ", "CHATOYIEZ"
    };

    string mystere = liste[random.Next(0, liste.Length)];
    int tentativesMax = 6;
    bool gagne = false;

    Console.WriteLine("=== BIENVENUE AU SUTOM ===");
    Console.WriteLine($"Trouvez le mot de {mystere.Length} lettres.");
    Console.WriteLine("Indice : La première lettre est " + mystere[0]);
    Console.WriteLine();

    for (int t = 1; t <= tentativesMax; t++)
    {
        Console.Write($"Tentative {t}/{tentativesMax} : ");
        string devine = Console.ReadLine()?.ToUpper();

        if (string.IsNullOrEmpty(devine) || devine.Length != mystere.Length)
        {
            Console.WriteLine($"Erreur : Le mot doit faire {mystere.Length} lettres.");
            t--; 
            continue;
        }

        for (int i = 0; i < mystere.Length; i++)
        {
            if (devine[i] == mystere[i])
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (mystere.Contains(devine[i].ToString()))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write(devine[i]);
            Console.ResetColor();
        }
        Console.WriteLine();

        if (devine == mystere)
        {
            gagne = true;
            break;
        }
    }

    if (gagne)
    {
        Console.WriteLine("\nFélicitations ! Vous avez trouvé le mot.");
    }
    else
    {
        Console.WriteLine($"\nDommage... Le mot était : {mystere}");
    }

    Console.WriteLine("Appuyez sur une touche pour quitter.");
    Console.ReadKey();
}
    }
}
