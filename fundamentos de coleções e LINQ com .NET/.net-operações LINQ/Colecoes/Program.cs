using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            // Valor min, max, medio
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum(); // Pega array soma e retorna um novo valor
            var arrayUnico = arrayNumeros.Distinct().ToArray(); // Pega array e retorna um array com valores unicos com base no array original

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

            // // Query syntax
            // var numerosParesQuery =
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;


            // // Method syntax
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Numeros pares query: " + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Numeros pares metodo: " + string.Join(", ", numerosParesMetodo));

        }
    }
}