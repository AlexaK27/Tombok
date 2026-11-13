using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November13Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           // alapok

           int[] pontok = new int[5];
           pontok[0] = 10;  // első elem 0-dik indexű
           pontok[1] = 20;
           pontok[2] = 30;
           pontok[3] = 40;
           pontok[4] = 50;

           Console.WriteLine($"Első: {pontok[0]}");
           Console.WriteLine($"Elemek száma: {pontok.Length}");
           Console.WriteLine($"Utolsó: {pontok[pontok.Length - 1]}");
           Console.WriteLine($"Utolsó: {pontok.Last()}"); // ez is jó ha az utolsót akarom kiirni

           Console.WriteLine("Összes elem:" + string.Join(",", pontok));   //Kiiratás vesszővel elválasztva

           int[] jegyek = { 5, 2, 5, 6, 2, 4, }; // ismert elem
           string[] nevek = { "Feri", "Elek", "János" };
           bool[] kapcsolok = new bool[3];
           Console.WriteLine("Összes elem:" + string.Join(",", kapcsolok));



           jegyek[2] = 4;
           Console.WriteLine(jegyek[3]);


           // Bejárások

           int[] szamok = { 1, 2, 3, 4, 5, 6 };
            // ha szeretnénk indexet akkor FOR ciklus
            for (int i = 0; i < szamok.Length; i++)
           {
               Console.WriteLine($"Index: {i}, érték: {szamok[i]}");
           }

            // ha nem szeretnénk indexet
           foreach(int szam in szamok)
           {
               Console.Write(szam + " ");
           }


           //visszafele kiirás
           for (int i = szamok.Length -1; i >=0; i--)
           {
               Console.WriteLine(szamok[i]);
           }



           //Beolvasás

           int[] adatok = new int[3];
           for (int i = 0; i < adatok.Length; i++) 
           {
               int szam;
               Console.WriteLine($"Add meg az {i+1}. számot");
               while (!int.TryParse(Console.ReadLine(), out szam))
               {
                   Console.WriteLine("Nem egész szám");
                   Console.Write($"Add meg az {i + 1}. számot");
               }
               adatok[i] = szam;
           }
           Console.WriteLine("Beolvasott szám:" + string.Join(",", adatok));


           //Tömbfeltöltés

           Random random = new Random();
           int[] randomszam = new int[10];
           for (int i = 0; i < randomszam.Length; i++)
           {
               // 1 és 10 között feltölteni számot
               randomszam[i] = random.Next(1, 11);
           }
           Console.WriteLine(string.Join(",", randomszam));


           // alap algoritmusok

           int[] numbers = { 2, 11, 42, 9, 1828, -3};

           int osszeg = 0;
           int minimum = szamok[0];
           int maximum = szamok[0];
           int MaxIndex = 0;

           for (int i = 0; i < numbers.Length; i++)
           {
               osszeg += numbers[i];

               if (numbers[i] < minimum)
                   minimum = numbers[i];

               if (numbers[i] > maximum)
               {
                   maximum = numbers[i];
                   MaxIndex = i;
               }
           }


           //Kasztolás (Típus kényszerítés)
           double atlag = (double)osszeg / numbers.Length;
           Console.WriteLine($"Összeg: {osszeg}");
           Console.WriteLine($"Átlag: {atlag}");
           Console.WriteLine($"Minimum: {minimum}");
           Console.WriteLine($"Maximum: {maximum}");
           Console.WriteLine($"Első max index: {MaxIndex}");
           */

            /*
            int[] sz = { 3, 7, 3, 5, 1, };
            int keresett = 7;
            int elsoIndex = -1;
            int db = 0;
            int parosdb = 0;

            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i] == keresett)
                {
                    db++;
                    if (elsoIndex == -1)
                        elsoIndex = i;
                }

                if (sz[i] % 2 == 0)
                    parosdb++;
            }

            bool vanBenne = elsoIndex != -1;
            Console.WriteLine($"Szerepel benne a {keresett}? {vanBenne}");
            Console.WriteLine($"Első előford: {elsoIndex}");
            Console.WriteLine($"Előford szam: {db}");
            Console.WriteLine($"Paros szam: {parosdb}");
            */


            //TÖMB FÜGGVÉNYEK
            /*
            int[] adatok = { 8, 2, 5, 1, 9 };
            Array.Sort(adatok); // Növekvő sorrendbe rendezés
            Array.Reverse(adatok); // csökkenő sorrend
            int index = Array.IndexOf(adatok, 5);  // keresés indexre  //ha nem találja meg akkor -1-et ad vissza

            int[] masolat = new int[adatok.Length];   //MÁSOLÁS
            Array.Copy(adatok, masolat, adatok.Length);  //MÁSOLÁS

            Array.Clear(masolat, 0, 2); // [0,2[ --> 0, 1 -es indexű elemet töröljük
            int osszeg = masolat.Sum();
            int min = masolat.Min();
            int max = masolat.Max();


            */


            // Szavak tagolása vagy mi
            string mondat = "Koczka el van vetve";
            string[] szavak = mondat.Split(' ');
            Console.WriteLine($"Szavak szama: {szavak.Length}");

            //Szavak kiirása
            foreach (var szo in szavak)
            {
                Console.WriteLine(szo);
            }


            // Csak a betűk kiirása
            char[] betuk = "Vetve".ToCharArray();
            foreach(var betu in betuk)
            {
                Console.WriteLine(betu);
            }




            Console.ReadLine();
        }
        static int Osszeg(int[] adatok)
        {
            int osszeg = 0;
            foreach(var szam in adatok)
            {
                osszeg += szam;
            }
            return osszeg;
        }

        static void NovelMindenMindennel(int[] adatok, int novekedes)
        {
            for(int i = 0; i<adatok.Length; i++)
            {
                adatok[i] += novekedes;
            }
        }



    }
}
