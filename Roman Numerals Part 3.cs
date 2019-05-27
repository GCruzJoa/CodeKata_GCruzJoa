using System;

namespace Roman_Numerals_Part_3
{
    class RomanNumerals3
    {
        public void ToRoman()
        {
            int number, units, dozens, hundreds, thousands;
            Console.Write("Write the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            units = number % 10; number /= 10; //945, units = 5, number = 94
            dozens = number % 10; number /= 10; //94, dozens = 4, number = 9
            hundreds = number % 10; number /= 10; //9, 9
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
            Console.ReadKey();
        }
        private int[] value;
        public void ToNatural()
        {
            string roman;
            value = new int[100];
            int n, i, number2 = 0;
            Console.Write("Write the roman number: ");
            roman = Console.ReadLine();
            n = roman.Length; 
            for (i = 0; i<=n; i++)
            {
                if (roman[i] == 'I' || roman[i] == 'i')
                {
                    value[i] = 1;
                }
                if (roman[i] == 'V' || roman[i] == 'v')
                {
                    value[i] = 5;
                }
                if (roman[i] == 'X' || roman[i] == 'x')
                {
                    value[i] = 10;
                }
                if (roman[i] == 'L' || roman[i] == 'l')
                {
                    value[i] = 50;
                }
                if (roman[i] == 'C' || roman[i] == 'c')
                {
                    value[i] = 100;
                }
                if (roman[i] == 'D' || roman[i] == 'd')
                {
                    value[i] = 500;
                }
                if (roman[i] == 'M' || roman[i] == 'm')
                {
                    value[i] = 1000;
                }
            }
            for (i = 0; i < n; i++)
            {
                if (i== n - 1)
                {
                    number2 += value[i];
                }
                else
                {
                    if (value[i] >= value[i + 1])
                    {
                        number2 += value[i];
                    }
                    else
                    {
                        number2 -= value[i];
                    }
                }
            }
            
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            RomanNumerals3 NaturalRoman = new RomanNumerals3();
            NaturalRoman.ToRoman();
            NaturalRoman.ToNatural();
        }
    }
}
