using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array) // Metodo para ordenar o array pelo algoritmo BubbleSort
        {
            int temp = 0; // Armazenar sem perder o valor anterior

            for (int i = 0; i < array.Length; i++) // Percorrer o array
            {
                for (int n = 0; n < array.Length - 1; n++) // Percorrer o array com a logica
                {
                    if (array[n] > array[n + 1])
                    {
                        temp = array[n + 1];
                        array[n + 1] = array[n];
                        array[n] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array) // Metodo para criar o array não ordenado
        {
            var linha = string.Join(", ", array); // Concatenando para imprimir em uma unica linha
            System.Console.WriteLine(linha);
        }

        // Classe array
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor) // Metodo para refericar se o array existe
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        // Metodo para verificar todos os elementos do array
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        // Metodos para encontrar um elementro no array e retornar seu valor
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor); // Encontrar um valor e retornar sua primeira ocorrencia
        }

        // Metodo para encontrar o indice de um valor
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor); // Receber seu valor e procurar por uma codição de igualdade
        }

        // Metodo para alterar o array
        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        // Metodo para converter array em outro tipo
        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString()); // Convertendo inteiro para string
        }

    }
}