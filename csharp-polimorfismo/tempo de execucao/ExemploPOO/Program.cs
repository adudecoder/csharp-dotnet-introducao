using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Victor";
            p1.Idade = 23;
            p1.Nota = 10;
            p1.Apresentar();


            Professor p2 = new Professor();
            p2.Nome = "Gabriel";
            p2.Idade = 35;
            p2.Salario = 2000;
            p2.Apresentar();
        }
    }
}