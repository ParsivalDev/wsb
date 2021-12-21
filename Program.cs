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

            Console.WriteLine("Wprowadz '+' dla dodawania, '-' dla odejmowani, '*' dla mnożenia lub '/' dla dzielenia");
            char znak = Console.ReadLine()[0];


            switch (znak)
            {
                case '+':

                    // dod
                    Console.WriteLine(liczba_j + liczba_d);
                    break;

                case '-':

                    Console.WriteLine(liczba_j - liczba_d);
                    // od
                    break;

                case '*':

                    Console.WriteLine(liczba_j * liczba_d);
                    break;

                case '/':

                    if(liczba_j == 0 || liczba_d == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0, sprobuj ponownie!");
                    }
                    else
                    Console.WriteLine(liczba_j / liczba_d);
                    break;

                default:
                    // brak
                    Console.WriteLine("Nie obsługuję takiego znaku!");
                    break;
            }
        }
    }
}
