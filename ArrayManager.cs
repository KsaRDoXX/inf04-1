using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF04_Aplikacja_Konsolowa___przeszukiwanie_tablicy_z_wartownikiem
{
    static public class ArrayManager
    {
        public static void RandWypelnianieTablicy(int[] tablica)
        {
            var rand = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(101);
            }
        }
        public static int WyszukajWartosc(int[] tablica, int wartosc)
        {
            tablica[tablica.Length - 1] = wartosc + 1;
            int index;

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == wartosc)
                {
                    index = i;
                    return index;
                }
            }

            return tablica.Length;
        }
        public static void WypiszTablice(int[] tablica)
        {
            Console.WriteLine("Zawartość tablicy :\n ");
            foreach (var item in tablica)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
        }
        

    }
}
