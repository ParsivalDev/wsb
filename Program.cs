using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int silnia1 = 1;
            Console.WriteLine("Silnia z liczby 9: ");
            for (int i = 1; i <= 9; i++)
            {

                silnia1 *= i; // silnia = silnia * i
                Console.WriteLine(silnia1);

            }
            double silnia3 = 1;
            Console.WriteLine("Silnia z liczby 20: ");
            for (double i = 1; i <= 20; i++)
            {

                silnia3 *= i; // silnia = silnia * i
                Console.WriteLine(silnia3);

            }


            ulong silnia2 = 1;
            Console.WriteLine("Silnia z liczby 243: ");
            for (ulong i = 1; i <= 243; i++)
            {

                silnia2 *= i; // silnia = silnia * i
                Console.WriteLine(silnia2);

            }
        }
    }
}

