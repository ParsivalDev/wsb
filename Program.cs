using System;

namespace ppk_main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ulong silnia = 1;
            for (ulong i = 1; i <= 243; i++)
            {

                silnia *= i; // silnia = silnia * i
                Console.WriteLine(silnia);

            }
        }
    }
}

