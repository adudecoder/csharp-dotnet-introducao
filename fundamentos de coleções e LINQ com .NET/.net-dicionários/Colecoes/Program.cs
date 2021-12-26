using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarando um dicionario
            Dictionary<string, string> estados = new Dictionary<string, string>();

            // Add elementos no dicionario
            estados.Add("SP", "São Paulo"); // Chave, valor. Não pode duplicar chave, apenas valor
            estados.Add("SP", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                // System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            // Acessando um valor no dicionario
            string valorProcurado = "BA";

            var teste = estados["SC"]; // var para quebrar o programa, acessando um chave inesistente

            // Acessando de maneira segura
            if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                System.Console.WriteLine(estadoEncontrado);
            }
            else
            {
                System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionario!");
            }

            // // Removendo um valor
            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]); // Retornara apenas valor

            // // Atualizando um valor
            // estados[valorProcurado] = "BA - Teste Atualização";
            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]); // Retornara apenas valor

        }
    }
}