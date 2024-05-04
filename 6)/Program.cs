Console.WriteLine("===Programa: Inversión de cadena==");
//Declarar variables
Console.Write("Ingrese la cadena de texto: ");
string s = Console.ReadLine();
//Resolver
int i = s.Length - 1;
string cadena = " ";
while (i >= 0)
{
    cadena += s[i];
    i = i - 1;
}
//Mostrar resultado
Console.WriteLine(cadena);
Console.ReadLine();