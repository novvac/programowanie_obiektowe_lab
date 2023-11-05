using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Licz licz1 = new Licz();
            Licz licz2 = new Licz();
            Licz licz3 = new Licz();

            Console.WriteLine("Zadanie 1.");

            licz1.Dodaj(5);
            licz2.Odejmij(2);
            Console.WriteLine($"Licz1: {licz1.value}");

            licz2.Dodaj(43);
            Console.WriteLine($"Licz1: {licz2.value}");

            licz3.Odejmij(56);
            Console.WriteLine($"Licz1: {licz3.value}");

            Console.WriteLine("\nZadanie 2.");

            int[] liczby = { 2, 4, 5, 3, 1 };
            Symulator symulator = new Symulator(liczby);
            Console.WriteLine($"Ilosc elementow: {symulator.IleElementow()}");
            symulator.Wypisz();
            Console.WriteLine($"Suma: {symulator.Suma()}");
            Console.WriteLine($"Suma z liczb podzielnych przez 2: {symulator.SumaPodziel2()}");
            Console.Write($"Elementy od 2 do 4: ");
            symulator.ShowSpecificItems(2, 3);

            Console.WriteLine("\nZadanie 3.");
        }
    }
}
