using System;

namespace Range_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, valueint; string interval, value = string.Empty;
            Console.WriteLine("Write the interval: ");
            interval = Console.ReadLine();

            if (interval.Contains("(") && interval.Contains(")"))
            {
                for (int i = 0; i<interval.Length; i++)
                {
                    if (char.IsDigit(interval[i]))
                    {
                        value += interval[i];
                    }
                }
                if (value.Length > 0)
                {
                    valueint = int.Parse(value);
                    b = valueint % 10; valueint /= 10;
                    a = valueint % 10; valueint /= 10;
                    Console.WriteLine("The open interval ({0},{1}) contains: ", a, b);
                    for (int iteration = a; iteration<b-1; iteration++)
                    {
                        Console.Write(iteration + 1 + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The endpoints of the interval are: " + (a + 1) + "," + (b - 1));
                }
            }
            if (interval.Contains("[") && interval.Contains("]"))
            {
                for (int i = 0; i < interval.Length; i++)
                {
                    if (char.IsDigit(interval[i]))
                    {
                        value += interval[i];
                    }
                }
                if (value.Length > 0)
                {
                    valueint = int.Parse(value);
                    b = valueint % 10; valueint /= 10;
                    a = valueint % 10; valueint /= 10;
                    Console.WriteLine("The closed interval [{0},{1}] contains: ", a, b);
                    for (int iteration = a; iteration <=b; iteration++)
                    {
                        Console.Write(iteration + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The endpoints of the interval are: " + (a) + "," + (b));
                }
            }
            if (interval.Contains("(") && interval.Contains("]")) 
            {
                for (int i = 0; i < interval.Length; i++)
                {
                    if (char.IsDigit(interval[i]))
                    {
                        value += interval[i]; 
                    }
                }
                if (value.Length > 0)
                {
                    valueint = int.Parse(value);
                    b = valueint % 10; valueint /= 10;
                    a = valueint % 10; valueint /= 10;
                    Console.WriteLine("The half-open interval ({0},{1}] contains: ", a, b);
                    for (int iteration = a; iteration < b; iteration++)
                    {
                        Console.Write(iteration + 1 + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The endpoints of the interval are: " + (a + 1) + "," + (b));
                }
            }
            if (interval.Contains("[") && interval.Contains(")"))
            {
                for (int i = 0; i < interval.Length; i++)
                {
                    if (char.IsDigit(interval[i]))
                    {
                        value += interval[i];
                    }
                }
                if (value.Length > 0)
                {
                    valueint = int.Parse(value);
                    b = valueint % 10; valueint /= 10;
                    a = valueint % 10; valueint /= 10;
                    Console.WriteLine("The half-open interval [{0},{1}) contains: ", a, b);
                    for (int iteration = a; iteration <=b-1; iteration++)
                    {
                        Console.Write(iteration + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("The endpoints of the interval are: " + (a) + "," + (b-1));
                }
            }
            Console.ReadKey();

        }
    }
}
