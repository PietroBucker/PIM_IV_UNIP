using System;
using System.Collections.Generic;
using System.IO;

public static class Relatorios
{
    private static string caminhoArquivo = "empresas.csv";

    public static void MostrarRelatorios()
    {
        Console.WriteLine("=== Relatórios ===");

        // Ler todas as linhas do arquivo CSV
        var linhas = new List<string>(File.ReadAllLines(caminhoArquivo));

        // Relatórios Individualizados
        Console.WriteLine("\nRelatórios Individualizados:");

        foreach (var linha in linhas)
        {
            var dados = linha.Split(',');

            Console.WriteLine($"Empresa: {dados[1]}");
            Console.WriteLine($"Quantidade de Resíduos Tratados: {dados[5]}");
            Console.WriteLine($"Período: {dados[6]}");
            Console.WriteLine($"Custo: {dados[7]}\n");
        }

        // Relatórios Globais
        Console.WriteLine("\nRelatórios Globais:");
        // Aqui, você pode adicionar a lógica para calcular as informações globais
    }

    public static void BaixarCSV()
    {
        try
        {
            // Obter o caminho da Área de Trabalho do usuário
            string caminhoAreaDeTrabalho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "empresas.csv");

            // Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Copiar o arquivo para a Área de Trabalho
                File.Copy(caminhoArquivo, caminhoAreaDeTrabalho, true);
                Console.WriteLine($"\nArquivo CSV foi baixado com sucesso para: {caminhoAreaDeTrabalho}");
            }
            else
            {
                Console.WriteLine("\nArquivo CSV não encontrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao tentar baixar o arquivo: {ex.Message}");
        }
    }


}
