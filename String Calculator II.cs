using System;

namespace String_Calculator_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b = string.Empty; int value;
            Console.WriteLine("Write the numbers separated by commas: ");
            a = Console.ReadLine(); 

            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]))
                {
                    b += a[i];
                }
            }          
            if (b.Length > 0)
            {
                value = int.Parse(b);
                int num4, num3, num2, num1, value2;
                num1 = value % 10; value /= 10;
                num2 = value % 10; value /= 10;
                num3 = value % 10; value /= 10;
                num4 = value % 10; value /= 10;

                value2 = num1 + num2 + num3 + num4;

                Console.WriteLine(value2);
            }
            if (b.Length == 0)
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
