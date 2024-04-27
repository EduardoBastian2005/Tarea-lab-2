// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine($"La suma de los dígitos de {numero} es: {sumaDigitos}");
    }

    static int CalcularSumaDigitos(int numero)
    {
        int suma = 0;

        while (numero != 0)
        {
            suma += numero % 10; // cuando divide deja residuo y eso lo suma
            numero /= 10; // Eliminar el último dígito
        }

        return suma;
    }
}
