using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Snooker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            string[] olvasottVersenyzok = File.ReadAllLines("Source\\snooker.txt");
            for (int i = 1; i < olvasottVersenyzok.Length; i++)
            {
                string[] tagok = olvasottVersenyzok[i].Split(';');
                Versenyzo ujVersenyzo = new Versenyzo(int.Parse(tagok[0]), tagok[1], tagok[2], int.Parse(tagok[3]));
                versenyzok.Add(ujVersenyzo);
            }

            //3.feladat: 
            Console.WriteLine($"3. feladat: A világranglistán {versenyzok.Count()} versenyző szerepel");

            //4.feladat:
            double osszBevetel = 0;
            int db = 0;

            foreach (var i in versenyzok)
            {
                osszBevetel += i.Nyeremeny;
                db++;
            }
            Console.WriteLine($"4. feladat: A versenyzők átlagosan {Math.Round(osszBevetel / db, 2)} fontot kerestek");

            //5.feladat:

            //6.feladat:
            bool norveg = false;
            Console.Write("6. feladat: ");
            foreach (var i in versenyzok)
            {
                if (i.Orszag == "Norvégia")
                {
                    norveg = true;
                    break;
                }
            }
            if (norveg == true)
            {
                Console.WriteLine("A versenyzők között van norvég versenyző");
            }
            else
            {
                Console.WriteLine("A versenyzők között nincs norvég versenyző");
            }

            //7.feladat:
        }
    }
}