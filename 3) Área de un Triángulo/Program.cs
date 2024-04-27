using System;

class Program
{
    static void Main()
    {
        float num1, num2;

        Console.Write("Inserta la altura del triángulo: ");
        num1 = float.Parse(Console.ReadLine());

        Console.Write("Inserta la base del triángulo: ");
        num2 = float.Parse(Console.ReadLine());

        if (num1 == 0 || num2 == 0)
        {
            Console.WriteLine("No se puede calcular el área, al menos uno de los valores es cero.");
        }
        else
        {
            float area = num1 * num2 / 2;
            Console.WriteLine("El área del triángulo es:", area);
        }
    }
}

