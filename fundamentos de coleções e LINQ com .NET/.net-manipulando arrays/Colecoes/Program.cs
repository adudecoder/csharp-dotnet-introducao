using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];
            // int valorProcurado = 9;
            string[] arrayString = op.ConverterParaArrayString(array);

            // Metodo para alterar o array
            System.Console.WriteLine($"Capacidade atual do array: {array.Length}"); // Exibir a capacidade atual
            op.RedimensionarArray(ref array, array.Length * 2); // Multiplicando o array atual

            System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}"); // Capacidade maior do array com os mesmo elementos de antes
            // Fim do metodo para alterar o array

            // Metodo para encontrar o indice de um valor
            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }
            // Fim do metodo para encontrar o indice de um valor

            // Metodo encontrar um valor no array
            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }
            // Fim do metodo encontrar um valor no array

            // Metodo para verificar todos os elementos do array
            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado); // All sendo maior que zero vai me retornar verdadeiro

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos o valores são maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }
            // Fim do metodo para verificar todos os elementos do array

            // Metodo para verificar se o valor do array existe
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }
            // Fim do metodo verificar se o valor do array existe

            // System.Console.WriteLine("Array original:");
            // op.ImprimirArray(array); // Metodo para imprimir array não ordenado

            // op.OrdenarBubbleSort(ref array); // Metodo BubbleSort que ordena o array passando a referencia do array. Trabalhando com o mesmo array
            // op.Ordenar(ref array); // Metodo Ordenar que utiliza a Classe Array atraves do metodo Sort
            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array); // Imprimindo array ordenado

            // Metodo copiar array
            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia:");
            // op.ImprimirArray(arrayCopia);
            // Fim do metodo copiar array

        }
    }
}