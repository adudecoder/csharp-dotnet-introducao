namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Victor";
        private readonly string sobrenome;

        // Dois construtores
        public Pessoa() // Construtor sem parametro recebe strings vazias
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome) // Construtor com parametros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            // this.nome = "Teste"; // Erro no codigo
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}