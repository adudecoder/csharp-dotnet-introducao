using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(); // Instanciando a classe Data
            //data.SetMes(2);

            data.Mes = 12;
            //System.Console.WriteLine(data.Mes); // Acessar propriedade

            data.ApresentarMes();
        }
    }
}
