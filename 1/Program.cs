// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main() 
    {
        float num1, num2;

        // Pedir al usuario que ingrese dos números
        Console.Write("Ingrese el primer número: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = float.Parse(Console.ReadLine());

        // Realizar las operaciones y mostrar los resultados
        Console.WriteLine($"Suma: {num1 + num2}");
        Console.WriteLine($"Resta: {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1 * num2}");

        // Verificar si el segundo número es cero antes de la división
        if (num2 != 0)
        {
            Console.WriteLine($"División: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
    }
}
