using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarando um array multidimensional
            int[,] matriz = new int[4, 2];
            matriz[0, 0] = 5; // Na linha 0, coluna 0, coloque o valor 5

            int[,] matriz2 = new int[4, 2] // Iniciando array multidimensional com valores
            {
                // 4 linhas
                { 8, 8 }, // Primeira coluna e segunda coluna
                { 10, 20 },
                { 50, 100 },
                { 90, 200 }
            };

            for (int i = 0; i < matriz2.GetLength(0); i++) // Percorrendo linha
            {
                for (int n = 0; n < matriz2.GetLength(1); n++) // Percorrendo coluna
                {
                    System.Console.WriteLine(matriz2[i, n]); // Imprimir os valores das linhas e colunas
                }
            }

            // int[] arrayInteiros = new int[3]; // Array com 3 capacidades
            // Adicionando numeros dentro do array
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30"); // Converter string em number

            // Index fora do array
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++) // Percorrendo o array
            // {
            //     System.Console.WriteLine(arrayInteiros[i]); // Imprimindo os valores do array
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros) // Percorrendo o array
            // {
            //     System.Console.WriteLine(item); // Imprimindo os valores do array
            // }
        }
    }
}