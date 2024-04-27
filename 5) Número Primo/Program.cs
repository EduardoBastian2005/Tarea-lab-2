// See https://aka.ms/new-console-template for more information
using System{
    static void Main()
    {
        float num1;
        Console.Write("Inserte el numero que quiere saber si es primo");
        num1= float.Parse(Console.ReadLine());
        if (num1 == 0 || num1 == 1) ;
        {
            Console.WriteLine("no tiene primo");
        }

        else(num1 % == 0);
        {
            Console.WriteLine("Es un numero primo");
        }
    }
}