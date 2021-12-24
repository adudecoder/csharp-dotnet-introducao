using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class Log
            Log log = Log.GetIsntance(); // Pegando instancia do log e colocando na variavel

            log.PropriedadeLog = "Teste instancia"; // Preenchida com teste instancia da variavel log

            Log log2 = Log.GetIsntance(); // Segunda variavel chamando a mesma instancia
            System.Console.WriteLine(log2.PropriedadeLog);

            // Class Pessoa
            Aluno p1 = new Aluno("Victor", "Martins", "Teste"); // Instanciando classe Aluno erdando de Pessoa
            p1.Apresentar();
        }
    }
}
