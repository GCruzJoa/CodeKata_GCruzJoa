using System;

namespace Roman_Numerals_Parte_I
{
    class Program
    {
        static void Main(string[] args)
        {
            byte answer = 1;
            do
            {
                    int number;
                    Console.WriteLine("Write the number: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1: Console.WriteLine("I"); break;
                        case 2: Console.WriteLine("II"); break;
                        case 3: Console.WriteLine("III"); break;
                        case 4: Console.WriteLine("IV"); break;
                        case 5: Console.WriteLine("V"); break;
                        case 6: Console.WriteLine("VI"); break;
                        case 7: Console.WriteLine("VII"); break;
                        case 8: Console.WriteLine("VIII"); break;
                        case 9: Console.WriteLine("IX"); break;
                        case 10: Console.WriteLine("X"); break;
                        case 20: Console.WriteLine("XX"); break;
                        case 30: Console.WriteLine("XXX"); break;
                        case 40: Console.WriteLine("XL"); break;
                        case 50: Console.WriteLine("L"); break;
                        case 60: Console.WriteLine("LX"); break;
                        case 70: Console.WriteLine("LXX"); break;
                        case 80: Console.WriteLine("LXXX"); break;
                        case 90: Console.WriteLine("XC"); break;
                    }
                
                char question;

                Console.WriteLine("Do you want to write another number? Y/N?");
                question = Convert.ToChar(Console.ReadLine().ToLower());
                    switch (question)
                    {
                        case 'Y': answer = 1; break;
                        case 'N': answer = 0; break;
                    }
                

            } while (answer == 1);
            Console.ReadKey();
        }
    }
}
