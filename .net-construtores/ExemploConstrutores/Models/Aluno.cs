namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa // Erda de Pessoa
    {
        //Recebendo tres parametros e passando esses mesmo parametros pra classe mãe sem o disciplina
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe aluno!");
        }
    }
}