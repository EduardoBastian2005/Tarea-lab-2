using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese los números separados por comas
        Console.WriteLine("Ingresa una lista de números separados por comas:");
        string input = Console.ReadLine();
        // Dividir la entrada en una matriz de cadenas usando la coma como delimitador
        string[] NUMEROS= input.Split(',');

        // Convertir las cadenas a números enteros
        List<int> numeros = new List<int>();
        foreach (string NUM in NUMEROS)
        {
            if (int.TryParse(NUM, out int num))
            {
                numeros.Add(num);
            }
            else
            {
                Console.WriteLine( NUMEROS + " no es un número válido y será omitido.");
            }
        }

        // Ordenar la lista de números de menor a mayor
        numeros.Sort();

        // Mostrar los números ordenados
        Console.WriteLine("Números ordenados de menor a mayor:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }
}

