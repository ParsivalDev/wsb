using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbe nr 1");
            int liczba_j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz liczbe nr 2");
            int liczba_d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wprowadz '+' dla dodawania lub '-' dla odejmowani");
            char znak = Console.ReadLine()[0];


            if (znak == '-') {

                Console.WriteLine(liczba_j - liczba_d);

            }else if(znak == '+')
            {
                Console.WriteLine(liczba_j + liczba_d);
            }
            else
            {
                Console.WriteLine("nie obsługuję tego znaku");
            }
        }
    }
}
