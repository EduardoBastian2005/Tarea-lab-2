using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número inicial del rango:");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número final del rango:");
        int fin = Convert.ToInt32(Console.ReadLine());

        int sumaPares = SumarNumerosPares(inicio, fin);

        Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");
    }

    static int SumarNumerosPares(int inicio, int fin)
    {
        int suma = 0;
        // Iteramos sobre el rango y sumamos los números pares
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0) // Verificamos si el número es par
            {
                suma += i; // Sumamos el número par a la suma total
            }
        }
        return suma;
    }
}
