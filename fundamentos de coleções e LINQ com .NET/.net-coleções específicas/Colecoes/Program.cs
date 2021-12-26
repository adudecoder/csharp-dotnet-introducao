using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarando a pilha
            Stack<string> pilhaLivros = new Stack<string>(); // Opcional iniciar com elementos

            // Add elementos na pilha
            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código Limpo");

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso!");
            }
            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // Fim da pilha

            // // Declarando a fila
            // Queue<string> fila = new Queue<string>();

            // // Incluindo elementos na fila
            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // // Lendo fila
            // while (fila.Count > 0)
            // {
            //      System.Console.WriteLine($"Vez de: {fila.Peek()}"); // Saber qual vai ser o proximo elemento
            //      System.Console.WriteLine($"{fila.Dequeue()} atendido"); // Removendo elemento da fila
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

        }
    }
}