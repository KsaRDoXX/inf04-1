
using INF04_Aplikacja_Konsolowa___przeszukiwanie_tablicy_z_wartownikiem;
using System.Runtime.CompilerServices;

int[] tablica = new int[50];

ArrayManager.RandWypelnianieTablicy(tablica);
ArrayManager.WypiszTablice(tablica);

Console.WriteLine("Wpisz wartość, którą chcesz wyszukać w tablicy :");

int wartoscDoZnalezienia = 0;

bool success = int.TryParse(Console.ReadLine(), out wartoscDoZnalezienia);

if(success)
{
    int index = ArrayManager.WyszukajWartosc(tablica, wartoscDoZnalezienia);

    if(index != tablica.Length)
    {
        ArrayManager.WypiszTablice(tablica);
        Console.WriteLine("\n---\n");
        Console.WriteLine("Szukana wartość jest pod indeksem :" + index);
    } else
    {
        Console.WriteLine("W tablicy nie było szukanej wartości");
    }
    
}else
{
    Console.WriteLine("Coś poszło nie tak");
}



