using System;

namespace Roman_Numerals_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool question = true; byte answer;
            do {
                int number, units, dozens, hundreds, thousands;
                Console.Write("Write the number: ");
                number = Convert.ToInt32(Console.ReadLine());

                units = number % 10; number /= 10; 
                dozens = number % 10; number /= 10; 
                hundreds = number % 10; number /= 10;
                thousands = number % 10; number /= 10;

                switch (thousands)
                {
                    case 1: Console.Write("M"); break;
                    case 2: Console.Write("MM"); break;
                    case 3: Console.Write("MMM"); break;
                }
                switch (hundreds)
                {
                    case 1: Console.Write("C"); break;
                    case 2: Console.Write("CC"); break;
                    case 3: Console.Write("CCC"); break;
                    case 4: Console.Write("CD"); break;
                    case 5: Console.Write("D"); break;
                    case 6: Console.Write("DC"); break;
                    case 7: Console.Write("DCC"); break;
                    case 8: Console.Write("DCCC"); break;
                    case 9: Console.Write("CM"); break;
                }
                switch (dozens)
                {
                    case 1: Console.Write("X"); break;
                    case 2: Console.Write("XX"); break;
                    case 3: Console.Write("XXX"); break;
                    case 4: Console.Write("XL"); break;
                    case 5: Console.Write("L"); break;
                    case 6: Console.Write("LX"); break;
                    case 7: Console.Write("LXX"); break;
                    case 8: Console.Write("LXXX"); break;
                    case 9: Console.Write("XC"); break;
                }
                switch (units)
                {
                    case 1: Console.Write("I"); break;
                    case 2: Console.Write("II"); break;
                    case 3: Console.Write("III"); break;
                    case 4: Console.Write("IV"); break;
                    case 5: Console.Write("V"); break;
                    case 6: Console.Write("VI"); break;
                    case 7: Console.Write("VII"); break;
                    case 8: Console.Write("VIII"); break;
                    case 9: Console.Write("IX"); break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to write another number?");
                do
                {                 
                    Console.WriteLine("Type 1 to write another number.");
                    Console.WriteLine("Type 0 to end.");
                    answer = Convert.ToByte(Console.ReadLine());
                
                    switch (answer)
                    {
                        case 1: Console.Clear(); break;
                        case 0: question = false; break;
                        default: Console.WriteLine("Your answer is not an option. Please select a possible option."); Console.WriteLine(); ; break;
                    }
                } while (answer != 1 && answer != 0);

            } while (question == true);
            Console.ReadKey();
        }
    }
}
