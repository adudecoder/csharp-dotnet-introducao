using System;
using ExemploEncapsulamento.Models;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores validos
            Retangulo p = new Retangulo();
            p.DefinirMedidas(30, 30);
            
            System.Console.WriteLine($"Área: {p.ObterArea()}");

            // Valores invalidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(0, 0);
            
            System.Console.WriteLine($"Área: {r.ObterArea()}");
        }
    }
}
