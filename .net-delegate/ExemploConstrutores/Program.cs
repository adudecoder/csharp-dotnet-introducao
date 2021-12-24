using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            // Operacao op = Calculadora.Somar; Outra maneira de passar o metodo para o delegate sem chamar a palavra new
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair; // Estenção do delegate

            // Ambos maneira valida de chamar o delegate
            op.Invoke(10, 10);
            // op(10, 10);
        }
    }
}
