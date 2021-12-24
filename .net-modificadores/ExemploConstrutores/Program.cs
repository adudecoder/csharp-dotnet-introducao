using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de constante
            const double pi = 3.14;
            System.Console.WriteLine(pi);

            // pi = 0; // Erro de constante


            Data data = new Data(); // Instanciando a classe Data
            //data.SetMes(2);

            data.Mes = 12;
            //System.Console.WriteLine(data.Mes); // Acessar propriedade

            data.ApresentarMes();
        }
    }
}
