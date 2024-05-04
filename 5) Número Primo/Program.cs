using System;

class Program
{
    static void Main()
    {
        float num1;
        Console.Write("Inserte el número para determinar si es primo: ");
        num1 = float.Parse(Console.ReadLine());

        if (num1 == 0 || num1 == 1)
        {
            Console.WriteLine("No es un número primo.");
        }
        else
        {
            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(num1); i++)
            {
                if (num1 % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("Es un número primo.");
            }
            else
            {
                Console.WriteLine("No es un número primo.");
            }
        }
    }
}
