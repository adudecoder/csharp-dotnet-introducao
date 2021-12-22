using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set;}

        public sealed override void Apresentar() // Usando SEALED para SELAR o METODO.
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou um professor, e ganho {Salario}");
        }
    }
}