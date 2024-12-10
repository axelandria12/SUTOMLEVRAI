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
            //Console.WriteLine("cool");
            Random random = new Random();
            int[] taille = new int[4];
            taille[0] = 6;
            taille[1] = 7;
            taille[2] = 8;
            taille[3] = 9;
            
            int tirage1 = random.Next(0,3);
            int taille1 = taille[tirage1];
            Console.WriteLine(taille1);
            

            Console.WriteLine("Trouvez le mot mystère");
            Console.WriteLine("  123456789");


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

            
            int tirage = random.Next(0,11);

            string mystere = liste[tirage];
            //DEBUG
            Console.WriteLine(mystere);
            Console.WriteLine(  );
            Console.WriteLine("Trouvez le mot mystère");
            

            for (int i = 1; i <= mystere.Length; i++) 
            {
                Console.WriteLine(mystere[0]);
                string devine = Convert.ToString(Console.Read());
                Console.Write(devine);
                if (devine[i] == mystere[i])
                {
                    Console.ForegroundColor = (ConsoleColor.Green);
                    Console.Write(devine[i]);
                    Console.WriteLine("cole");
                }
                
                //Console.WriteLine(devine);
            }
            //for (int i = 1; i < mystere.Length; i++)
            //{
            //   string devine =Console.ReadLine();
            //        if (mystere[i] == devine[i])
            //        {
            //            Console.ForegroundColor = (ConsoleColor.Green);
            //            Console.WriteLine(devine);
            //            Console.ResetColor();
            //        }
            //        else
            //        {
            //        while (mystere[i] != devine[i])
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine(devine[i]);
            //            Console.ResetColor();
            //            devine = Console.ReadLine();
            //        }
            //        Console.WriteLine(devine);
            //}

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
