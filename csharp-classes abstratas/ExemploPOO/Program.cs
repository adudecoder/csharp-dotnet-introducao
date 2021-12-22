using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();
        }
    }
}