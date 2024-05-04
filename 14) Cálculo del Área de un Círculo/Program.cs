using System;

class Program
{
    static void Main()
    {
        int num1, area;
        Console.Write("Escriba el radio del círculo: ");
        num1 = int.Parse(Console.ReadLine());

        if (num1 == 0)
        {
            Console.WriteLine("El radio del círculo es cero, el área no existe.");
        }
        else
        {
            area = (int)(Math.PI * Math.Pow(num1, 2));
            Console.WriteLine("El área del círculo es" + area);
        }
    }
}
