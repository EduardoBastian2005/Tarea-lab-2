// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Número de términos de la serie Fibonacci a generar
        int n = 10;

        // Variables para almacenar los dos primeros términos de la serie
        int a = 0, b = 1;

        // Mostrar el primer término (0)
        Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
        Console.Write(a + " ");

        // Generar y mostrar los siguientes términos de la serie Fibonacci
        for (int i = 2; i <= n; i++){
            int temp = a + b; // suma los numeros anteriores para dar el numero siguiente
            Console.Write(temp + " "); // pone el numero temp y el espacio
            a = b; // cambia el b por el a
            b = temp; // y el temp por el b
        }
    }
}
