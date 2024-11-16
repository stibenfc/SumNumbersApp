using System;

class Program
{
    static void Main (string[] args)
    {
        //Solicitar al usuario el primer número
        Console.Write("Ingresa el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        //Solicitar al usuario el segundo número
        Console.Write("Ingresa el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        //Sumar los números
        int suma = numero1 + numero2;

        //Mostrar el resultado
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");

        Console.WriteLine("Hola Mundo");

    }
}
