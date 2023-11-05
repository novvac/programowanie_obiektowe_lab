using System;

namespace Lab2
{
    class Symulator {
        private int[] Liczby;

        public Symulator(int[] liczby) {
            this.Liczby = liczby;
        }

        public int IleElementow() {
            return this.Liczby.Length;
        }

        public void Wypisz() {
            Console.WriteLine("Elementy tablicy: ");
            Console.Write("> ");
            foreach (int i in this.Liczby)
            {
                Console.Write($"{i} ");
            }
            Console.Write('\n');
        }

        public int Suma() {
            int sum = 0;

            for (int i = 0; i < this.Liczby.Length; i++)
            {
                sum += this.Liczby[i];
            }

            return sum;
        }

        public int SumaPodziel2() {
            int sum = 0;

            foreach (int i in this.Liczby) {
                if (i % 2 == 0)
                    sum += i;
            }

            return sum;
        }

        public void ShowSpecificItems(int lowIndex, int highIndex) {
            int low = lowIndex >= 0 ? lowIndex : 0;
            int high = highIndex <= this.Liczby.Length ? highIndex : this.Liczby.Length;

            Console.WriteLine($"{low} / {high}");

            Console.Write("> ");
            for(int i = low; i <= high; i++)
            {
                Console.Write($"{this.Liczby[i]} ");
            }
        }
    }
}
