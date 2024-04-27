// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1 // estable el valor en 1
            ; i <= 12 // solo hasta 12
            ; i++ // suma un 1 hasta llegar a 12
            )
        {
            Console.WriteLine({numero} ,"x", {i} ,"=", {numero * i}); // remplaza cada i por el numero y los multiplica
        }
    }
}
