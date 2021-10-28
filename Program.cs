using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2005_majus
{
    class Program
    {
        static void Main(string[] args)
        {
            //vhogy szét kéne szedni a sorozatot, de a sorokat nem lehet splitelni
            string[] sorok = File.ReadAllLines("lottosz.dat");
            List<Szam> szamok = new List<Szam>();
            int[] Ertek = new int[255];
            foreach (string sor in sorok)
            {
                //szamok.Add(new Szam(sor));
                string[] s = sor.Split(' ');
                int vege = s.Length;

                
                for (int i = 0; i < vege; i++)
                { //mindig az első ötöt írja felül!!!!!!!!!!!
                    Ertek[i] = int.Parse(s[i]);
                }
            }
                    


        /*
        string[] osszesSzam = new string[sorok.Length];
        for (int i = 0; i < sorok.Length; i++)
        {
            string o = sorok[i].Split(' ');
            osszesSzam[i] = o;
        }*/

        /* 1 - kérje be az 52.hét lottószámait */
        Console.WriteLine("Adj meg 5 számot, szóközzel elválasztva!");
            string valasz = Console.ReadLine();

            /* 2- Rendezze a bekért számokat emelkedő sorrendbe, a rendezett számokat írja ki! */
            string[] valaszok = valasz.Split(' ');
            int h = valaszok.Length;
            int[] tomb = new int[h];
            for (int i = 0; i < h; i++)
            {
                int szam = int.Parse(valaszok[i]);
                tomb[i] = szam;
            }
            Array.Sort(tomb);
            foreach (var item in tomb)
            {
                Console.Write(item + " ");
            }

            /* 3- Kérjen be a felhasználótól egy egész számot 1-51 között! */
            Console.WriteLine("\nAdj meg 1 db egész számot!");
            int megadott = int.Parse(Console.ReadLine());

            /* 4- Írja ki a képernyőre a bekért számnak megfelelő sorszámú hét lottószámait, a
               lottosz.dat állományban lévő adatok alapján! */
            Console.WriteLine($"\nA {megadott}. heti lottószámok a következőek voltak: {sorok[megadott]}");


            /* 5. A lottosz.dat állományból beolvasott adatok alapján döntse el, hogy volt-e olyan
            szám, amit egyszer sem húztak ki az 51 hét alatt! A döntés eredményét (Van/Nincs) írja ki
            a képernyőre! 0-90 vannak a számok */

            bool van = false; //11-et nem húzták ki
            int szamol = 0;
            int j = 0;
            /*
            while (szamol == int.Parse(sorok[j]))
            {
                szamol++;
                if (szamol != int.Parse(sorok[j]))
                {
                    van = true;
                }
            }*/

            Console.WriteLine(van ? "van" : "nincs" );
            
            for (int i = 0; i < 254; i++)
            {
                Console.WriteLine(Ertek[i]);
            }
            
            



            Console.ReadKey();

        }
    }
}
