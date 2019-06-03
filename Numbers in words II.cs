using System;

namespace Numbers_in_words_II
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number, number2, thousands, hundreds, dozens, units;
                bool question = true; int answer;
                do
                {
                    Console.Write("Write the number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    number2 = number;
                    units = number % 10; number /= 10;
                    dozens = number % 10; number /= 10;
                    hundreds = number % 10; number /= 10;
                    thousands = number % 10; number /= 10;
                    Console.Write("Number in words: ");
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
                    if (number2 > 100)
                    {
                        Console.Write("and ");
                    }
                    switch (dozens)
                    {
                        case 1:
                            switch (units)
                            {
                                case 1: Console.Write("Eleven "); break;
                                case 2: Console.Write("Twelve "); break;
                                case 3: Console.Write("Thirteen "); break;
                                case 4: Console.Write("Fourteen "); break;
                                case 5: Console.Write("Fifteen "); break;
                                case 6: Console.Write("Sixteen "); break;
                                case 7: Console.Write("Seventeen "); break;
                                case 8: Console.Write("Eighteen "); break;
                                case 9: Console.Write("Nineteen "); break;
                            }
                            break;
                        case 2: Console.Write("Twenty "); break;
                        case 3: Console.Write("Thirty "); break;
                        case 4: Console.Write("Fourty "); break;
                        case 5: Console.Write("Fifty "); break;
                        case 6: Console.Write("Sixty "); break;
                        case 7: Console.Write("Seventy "); break;
                        case 8: Console.Write("Eighty "); break;
                        case 9: Console.Write("Ninety "); break;
                    }
                    if (dozens != 1)
                    {
                        switch (units)
                        {
                            case 1: Console.Write("One"); break;
                            case 2: Console.Write("Two"); break;
                            case 3: Console.Write("Three"); break;
                            case 4: Console.Write("Four"); break;
                            case 5: Console.Write("Five"); break;
                            case 6: Console.Write("Six"); break;
                            case 7: Console.Write("Seven"); break;
                            case 8: Console.Write("Eight"); break;
                            case 9: Console.Write("Nine"); break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Do you want to write another number? ");
                    do
                    {
                        Console.WriteLine("Type 1 to write another number.");
                        Console.WriteLine("Type 0 to end.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        switch (answer)
                        {
                            case 1: Console.Clear(); break;
                            case 0: question = false; break;
                            default: Console.WriteLine("Your answer is not an option. Please select one of the possible options."); break;
                        }
                    } while (answer != 1 && answer != 0);
                } while (question == true);
            }
            catch (Exception error)
            {
                Console.WriteLine("You have to type a number. ", error.Message); 
            }
        }

    }
}
