using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor();

            p1.Salario = 2000;
            p1.Nome = "Victor";
            p1.Idade = 23;

            p1.Apresentar();
        }
    }
}