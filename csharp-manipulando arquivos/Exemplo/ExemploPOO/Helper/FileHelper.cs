using System.IO;
using System.Collections.Generic;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories); // Listar somente os arquivos .txt

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho) // Metodo para criar diretorios
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos) // Metodo para deletar diretorio e arquivos passando um parametro boolean
        {
            Directory.Delete(caminho, apagarArquivos); // Passando o caminho do parametro boolean
        }

        public void CriarArquivoTexto(string caminho, string conteudo) // Metodo para criar arquivos
        {
            if (!File.Exists(caminho)) // If para que o metodo não sobscreva o conteudo do arquivo
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo) // Metodo para criar arquivos streams
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo) // Metodo para add novas linhas em um arquivo
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo) // Metodo para add linhas no arquivo stream
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho) // Metodo para ler os arquivos
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        // public void LerArquivoStream(string caminho) // Metodo para ler os arquivos stream
        // {
        //     string linha = string.Empty;

        //     using (var stream = File.OpenText(caminho))
        //     {
        //         while ((linha = stream.ReadLine()) !- null)
        //         {
        //             System.Console.WriteLine(linha);
        //         }
        //     }
        // }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever) // Metodo para mover os arquivos
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever) // Metodo para copiar os arquivos
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho) // Metodo para deletar os arquivos
        {
            File.Delete(caminho);
        }
    }
}