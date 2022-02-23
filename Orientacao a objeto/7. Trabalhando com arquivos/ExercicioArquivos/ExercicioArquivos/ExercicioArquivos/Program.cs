// Exercicio proposto:
//
// Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos. Cada item possui um
// nome, preço unitário e quantidade, separados por vírgula. Você deve gerar um novo arquivo chamado "summary.csv",
// localizado em uma subpasta chamada "out" a partir da pasta original do arquivo de origem, contendo apenas o
// nome e o valor total para aquele item (preço unitário multiplicado pela quantidade).

using System;
using System.Collections.Generic;
using System.IO;
using ExercicioArquivos.Entities;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Code\WS - VisualStudio\Curso C#\Orientação a objeto\8. Uso de arquivos\arquivo\exercicio.csv";
            Directory.CreateDirectory(@"C:\Code\WS - VisualStudio\Curso C#\Orientação a objeto\8. Uso de arquivos\arquivo\\out");
            string targetPath = @"C:\Code\WS - VisualStudio\Curso C#\Orientação a objeto\8. Uso de arquivos\arquivo\out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                Produto produto = new Produto();
                var prod = new List<Produto>();

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] campo = lines[i].Split(";");
                        string nome = campo[0];
                        double preco = double.Parse(campo[1]);
                        int quantidade = int.Parse(campo[2]);

                        produto = new Produto(nome, preco, quantidade);
                        produto.ValorTotal(preco, quantidade);
                        prod.Add(produto);
                    }

                    foreach (Produto linha in prod)
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
