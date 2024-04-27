// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        float num1;
        // Verificación de Número Par o Impar
        Console.Write("Ingrese el número que desea verificar como par o impar: ");
        num1 = float.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine($"{num1} es un número par");
        }
        else
        {
            Console.WriteLine($"{num1} es impar");
        }
    }
}

