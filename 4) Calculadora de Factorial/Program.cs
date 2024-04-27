using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("El factorial no está definido para números negativos.");
        }
        else
        {
            long factorial = CalcularFactorial(num);
            Console.WriteLine($"El factorial de {num} es {factorial}");
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1; 
        }
        else
        {
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}

