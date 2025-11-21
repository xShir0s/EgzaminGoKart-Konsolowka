using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKartEgzamin
{
        /* 
 klasa: Program

 opis:  Klasa główna aplikacji obliczająca NWD dla serii czasów podanych w sekundach.
        Realizuje funkcję pobierania danych od użytkownika oraz obliczenia matematyczne.

 pola:  brak

 metody: 
        Nwd(int a, int b) - zwraca liczbę całkowitą (int), oblicza NWD dwóch liczb algorytmem Euklidesa.
        Czas() - zwraca liczbę całkowitą (int), pobiera od użytkownika wartość czasu w sekundach.
        Main(string[] args) - metoda główna, steruje przebiegiem programu.

 autor: Miłosz Todys
 */

    
    internal class Program
    {

    public int Nwd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;

            }
            return a;
        }

        public int Czas()
        {
            Console.WriteLine("Podaj czas w sekundach: ");
           int a = Convert.ToInt32(Console.ReadLine());
            return a;

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Podaj czasy Użytkownika");
            int czas1 = p.Czas();
            int czas2 = p.Czas();
            int nwd = p.Nwd(czas1, czas2);
            int czas3 = p.Czas();
            int nwd2 = p.Nwd(nwd, czas3);
            int czas4 = p.Czas();
            int nwd3 = p.Nwd(nwd2, czas4);
            Console.WriteLine("Największy wspólny dzielnik czasów to: " + nwd3 + " sekund");



        }
    }
}
