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

            Console.WriteLine(liczba_d * liczba_j);
        }
    }
}

