using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Bienvenido a la calculadora de sumas");
            Console.WriteLine("Por favor inserte el primer numero a sumar:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor inserte el segundo numero a sumar:");
            n2 = int.Parse(Console.ReadLine());
            n3 = n1 + n2;
            Console.WriteLine("La suma entre " + n1 + " y " + n2 + " tiene como resultado: " + n3);
            Console.WriteLine("Gracias por utilizar la calculadora de sumas");
        }
    }
}
