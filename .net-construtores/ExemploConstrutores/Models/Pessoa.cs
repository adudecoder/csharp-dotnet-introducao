namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        // Dois construtores
        // public Pessoa() // Construtor sem parametro recebe strings vazias
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome) // Construtor com parametros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}