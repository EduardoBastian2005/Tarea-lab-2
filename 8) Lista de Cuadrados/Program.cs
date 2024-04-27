// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> cuadrados = new List<int>();//lista entera cuadrsdos es igual a una lista nueva

        for (int i = 1 // desde el rango 1
            ; i <= 10 // hasta el 10
            ; i++) // se ira sumando a i + 1
        {
            cuadrados.Add(i * i); // se añade cada respuesta a la lista de cuadrados creada
        }
        Console.WriteLine("Cuadrados de los primeros 10 números naturales:");
        foreach (int cuadrado in cuadrados) // foreac se usa para iterar en la lista de cuadrados creada
        {
            Console.WriteLine(cuadrado); //imrpimir la lista cudrados
        }
    }
}
