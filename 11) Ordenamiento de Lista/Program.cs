// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> cuadrados = new List<int>();

        // Generar los cuadrados de los primeros 10 números naturales
        for (int i = 1; i <= 10; i++)
        {
            int cuadrado = i * i;
            cuadrados.Add(cuadrado);
        }

        // Mostrar los cuadrados
        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }
    }
}
