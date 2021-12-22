using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
        }
    }
}