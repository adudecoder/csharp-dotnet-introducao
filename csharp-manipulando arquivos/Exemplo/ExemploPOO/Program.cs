using System; // Importe do sistema
using ExemploPOO.Helper; // Importe para criar todos os metedos
using System.IO; // Importe para os metodos de menipulação de arquivos
using System.Collections.Generic; // Importe para o metodo de criar arquivos streams

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:\\TrabalhandoComArquivos"; // Diretorio das pastas
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1"); // Caminho para criar as pastas
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt"); // Caminho para criar os arquivos
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste-stream.txt");
            var CaminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var CaminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");

            // Listando um array para os metodos de add novas linhas no arquivo
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper(); // Importando a class FileHelper.cs
            // helper.ListarDiretorios(caminho); // Listando os diretorios
            // helper.ListarArquivosDiretorios(caminho); // Listando os arquivos dentro dos diretorios

            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine); // Criando pastas e SubPastas

            // helper.ApagarDiretorio(caminhoPathCombine, true); // Usando true para acessar o metodo delete e apagar diretorios que não estejam vazios

            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo"); // Criando o arquivo e o conteudo

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString); // Criando os arquivos streams
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao); // Criando novas linhas dentro do arquivo stream

            // helper.LerArquivoStream(caminhoArquivo); // Lendo arquivo stream

            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false); // Movendo o arquivo

            // helper.CopiarArquivo(CaminhoArquivoTeste, CaminhoArquivoTesteCopia, false); // Copiando arquivo de bkp

            helper.DeletarArquivo(CaminhoArquivoTesteCopia); // Deletando arquivo
        }
    }
}