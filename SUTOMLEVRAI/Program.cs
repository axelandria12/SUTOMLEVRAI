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
            Console.WriteLine("Trouvez le mot mystère");
            Console.WriteLine("  123456789");
            string[] liste = new string[12];
            liste[0] = "ASPHYXIEZ";
            liste[1] = "HYDROXYDE";
            liste[2] = "PEROXYDEZ";
            liste[3] = "KAMIKAZES";
            liste[4] = "KLAXONNEZ";
            liste[5] = "HYPOPHYSE";
            liste[6] = "EXPLIQUEZ";
            liste[7] = "EXTORQUEZ";
            liste[8] = "EFFRAYIEZ";
            liste[9] = "FOURVOYEZ";
            liste[10] = "FLAMBOYEZ";
            liste[11] = "CHATOYIEZ";
            Random random = new Random();
            int tirage = random.Next(0,11);
            //Console.WriteLine(liste[tirage]);
            string mystere = liste[tirage];
            Console.WriteLine(mystere[0].ToString().ToUpper());
            string devine = Console.ReadLine();
            for (int i = 1; i < devine.Length; i++)
            { 
            }




            /*
            string[] mystere = new string[9];
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            int tirage = random.Next(0, 25);
            Console.WriteLine( "Tirage : {0}", tirage);

            Console.WriteLine(alphabet[tirage]);

            /*
            for (int i = 0; i < mystere.Length; i++)
            {
                mystere[i] = Convert.ToString(alphabet[random.Next(0, 25)]);
            }
            Console.WriteLine(mystere);

            */
            Console.ReadKey();
        }
    }
}
