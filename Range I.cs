using System;

namespace Range_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, type; string typeHalfInterval;
            Console.WriteLine("What is the type of interval?");
            Console.WriteLine("1 for an open interval");
            Console.WriteLine("2 for a closed interval");
            Console.WriteLine("3 for a half open interval");
            type = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("Write the endpoints of the open interval:");
                Console.Write("a: "); a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: "); b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("("+a+","+b+") contains: ");

                for (int i = a; i<b-1; i++)
                {
                    Console.Write(i + 1 + "-");
                }
                Console.WriteLine();
                Console.WriteLine("(" + a + "," + b + ")" + "endpoints are: {" +(a+1)+","+(b-1)+"}");
            }
            if (type == 2)
            {
                Console.WriteLine("Write the endpoints of the closed interval:");
                Console.Write("a: "); a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: "); b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("[" + a + "," + b + "] contains: ");

                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + "-");
                }
                Console.WriteLine();
                Console.WriteLine("[" + a + "," + b + "]" + " endpoints are: {"+a+","+b+"}");
            }
            if (type == 3)
            {
                Console.WriteLine("What type of half-open interval is?");
                Console.WriteLine("L for left-open interval");
                Console.WriteLine("R for right-open interval");
                typeHalfInterval = Console.ReadLine();

                Console.WriteLine("Write the endpoints of the half-open interval:");
                Console.Write("a: "); a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: "); b = Convert.ToInt32(Console.ReadLine());

                if (typeHalfInterval == "L" || typeHalfInterval == "l")
                {
                    Console.WriteLine("(" + a + "," + b + "] contains: ");
                    for (int i = a; i < b; i++)
                    {
                        Console.Write(i +1+ "-");
                    }
                    Console.WriteLine();
                    Console.WriteLine("(" + a + "," + b + "]" + " endpoints are: {" + a+1 + "," + b + "}");
                }
                if (typeHalfInterval == "R" || typeHalfInterval == "r")
                {
                    Console.WriteLine("[" + a + "," + b + ") contains: ");
                    for (int i = a; i < b-1; i++)
                    {
                        Console.Write(i + "-");
                    }
                    Console.WriteLine();
                    Console.WriteLine("[" + a + "," + b + ")" + " endpoints are: {" + a + "," + (b-1) + "}");
                }
            }


            Console.ReadKey();
        }
    }
}
