using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escribe una oración para contar el número de vocales: ");
        string cadena = Console.ReadLine(); // Leer la oración ingresada por el usuario
        int numeroVocales = ContarVocales(cadena); // contador para el número de vocales
        Console.WriteLine("El número de vocales en la cadena es: " + numeroVocales);
    }

    static int ContarVocales(string cadena)
    {
        // Convertir la cadena a minúsculas para simplificar la comparación, ya que la comparación es sensible
        cadena = cadena.ToLower();
        int contador = 0;
        // Definir un arreglo de caracteres que representan las vocales
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

        // Iterar a través de cada carácter en la cadena
        foreach (char caracter in cadena)
        {
            // Verificar si el carácter actual es una vocal
            if (Array.IndexOf(vocales, caracter) != -1)
            {
                contador++;
            }
        }
        Console.Write("La oración con la que comparas es: " + cadena); // Mostrar la oración para comparación
        return contador;
    }
}
