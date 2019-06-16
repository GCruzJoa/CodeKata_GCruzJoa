using System;

namespace String_Calculator_I
{
    class Program
    {
        static void Main(string[] args)
        {
            bool question = true; 
            do
            {
                int answer;
                string a, b = string.Empty; int value; //se declaran variables
                Console.WriteLine("Write the numbers separated by commas: "); // Se imprime en pantalla
                a = Console.ReadLine(); // Se lee el input

                for (int i = 0; i < a.Length; i++) // se evalua cada char del string
                {
                    if (char.IsDigit(a[i])) // Se verifica cual char es un digito
                    {
                        b += a[i]; // Se guardan los numeros del string
                    }
                }
                if (b.Length > 0) // Se verifica si se han guardado numeros del string
                {
                    value = int.Parse(b); // Se convierte a variable entera
                    int num4, num3, num2, num1, value2; // Se evalua cada digito del numero
                    num1 = value % 10; value /= 10;
                    num2 = value % 10; value /= 10;
                    num3 = value % 10; value /= 10;
                    num4 = value % 10; value /= 10;

                    value2 = num1 + num2 + num3 + num4;
                    Console.WriteLine(value2);
                }
                Console.WriteLine("Do you want to write another input?");
                do
                {
                    Console.WriteLine("Type 1 to write another input.");
                    Console.WriteLine("Type 0 to end.");
                    answer = Convert.ToInt32(Console.ReadLine());

                    switch (answer)
                    {
                        case 1: Console.Clear(); break;
                        case 0: question = false; break;
                        default: Console.WriteLine("Write a possible option."); break;
                    }
                } while (answer != 1 && answer != 0);
            } while (question!= false);
        }
    }
}
