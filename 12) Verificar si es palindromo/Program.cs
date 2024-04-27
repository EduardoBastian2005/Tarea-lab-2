// See https://aka.ms/new-console-template for more information
using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine(); // no avanza hasta que se ponga la palabra
        if (EsPalindromo(palabra)) // uso de la "funcion" verificr si es palindromo
        {
            Console.WriteLine("La palabra es un palíndromo."); // respuesta
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string palabra)
    {
        // Convertir la palabra a minúsculas para hacer la comparación de manera insensible a mayúsculas
        palabra = palabra.ToLower(); // Tolewer, copia la plabara y las hace minusculas

        // Iterar sobre la mitad de la palabra para comparar los caracteres de ambos extremos
        for (int i = 0; i < palabra.Length / 2; i++) //Length, da el numero de letras de la palabra
        {
            // Comparar el carácter actual con su correspondiente en la otra mitad de la palabra
            if (palabra[i] != palabra[palabra.Length- 1 // el numero de palabras -1 para que vaya recorriendo
                - i // vaya recorriendo con i
                ])
            {
                // Si hay alguna diferencia, la palabra no es un palíndromo
                return false;
            }
        }
        // Si no se encontraron diferencias, la palabra es un palíndromo
        return true;
    }
}
