using System;

namespace Number_in_words_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, thousands, hundreds, dozens, units;
            Console.Write("Write the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            units = number % 10;number /= 10;
            dozens = number % 10; number /= 10;
            hundreds = number % 10; number /= 10;
            thousands = number % 10; number /= 10;

            switch (thousands)
            {
                case 1: Console.Write("One thousand "); break;
                case 2: Console.Write("Two thousand "); break;
                case 3: Console.Write("Three thousand "); break;
                case 4: Console.Write("Four thousand "); break;
                case 5: Console.Write("Five thousand "); break;
                case 6: Console.Write("Six thousand "); break;
                case 7: Console.Write("Seven thousand "); break;
                case 8: Console.Write("Eight thousand "); break;
                case 9: Console.Write("Nine thousand "); break;
            }
            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }
            switch (dozens)
            {
                case 1: switch (units)
                    {
                        case 1: Console.Write("eleven "); break;
                        case 2: Console.Write("twelve "); break;
                        case 3: Console.Write("thirteen "); break;
                        case 4: Console.Write("fourteen "); break;
                        case 5: Console.Write("fifteen "); break;
                        case 6: Console.Write("sixteen "); break;
                        case 7: Console.Write("seventeen "); break;
                        case 8: Console.Write("eighteen "); break;
                        case 9: Console.Write("nineteen "); break;

                    }; break; 

                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Fourty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;
            }
            switch (units)
            {
                case 1: Console.Write("One "); break;
                case 2: Console.Write("Two "); break;
                case 3: Console.Write("Three "); break;
                case 4: Console.Write("Four "); break;
                case 5: Console.Write("Five "); break;
                case 6: Console.Write("Six "); break;
                case 7: Console.Write("Seven "); break;
                case 8: Console.Write("Eight "); break;
                case 9: Console.Write("Nine "); break;
            }
            Console.ReadKey();
        }
    }
}
