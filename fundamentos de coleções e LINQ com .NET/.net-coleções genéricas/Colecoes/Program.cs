using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>(); // Declarando uma List, também podemos iniciar com o valores do metodo Add List<string> estados = new List<string> { "SP", "MG", "BA" };
            string[] estadosArray = new string[2] { "SC", "MT" };

            // Adicionando elementos na List
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            // Add coleções na lista
            // estados.AddRange(estadosArray);

            estados.Insert(1, "RJ"); // Add elemento por indice

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}"); // Retornando o numero de elementos contido na List

            // Metodo de remoção de elemento
            opLista.ImprimirListaString(estados); // Imprimir estados sem usar os For
            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            opLista.ImprimirListaString(estados); // Ver o estado da remoção
            // Fim do metodo de remoção de elemento

            // foreach (var item in estados) // Imprimindo a lista
            // {
            //     System.Console.WriteLine(item);
            // }

            // Também pode se usar o For
            // for (int i = 0; i < estados.Count; i++) // Imprimindo a lista
            // {
            //     System.Console.WriteLine($"Indice {i}, valor: {estados[i]}");
            // }

        }
    }
}