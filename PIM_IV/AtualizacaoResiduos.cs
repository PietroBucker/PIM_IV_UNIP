using System;
using System.Collections.Generic;
using System.IO;

public static class AtualizacaoResiduos
{
    private static string caminhoArquivo = "empresas.csv";

    public static void AtualizarResiduos()
    {
        Console.WriteLine("=== Atualizar Resíduos ===");

        Console.Write("Digite o nome da empresa para atualizar: ");
        string nomeEmpresa = Console.ReadLine();

        // Ler todas as linhas do arquivo CSV
        var linhas = new List<string>(File.ReadAllLines(caminhoArquivo));
        bool empresaEncontrada = false;

        for (int i = 0; i < linhas.Count; i++)
        {
            var dados = linhas[i].Split(',');

            // Verificar se a empresa corresponde
            if (dados[1] == nomeEmpresa)
            {
                empresaEncontrada = true;
                Console.Write("Nova Quantidade de Resíduos Ambientais Tratados: ");
                string novaQuantidadeResiduos = Console.ReadLine();

                Console.Write("Novo Período: ");
                string novoPeriodo = Console.ReadLine();

                Console.Write("Novo Custo: ");
                string novoCusto = Console.ReadLine();

                // Atualizar a linha da empresa
                dados[5] = novaQuantidadeResiduos;
                dados[6] = novoPeriodo;
                dados[7] = novoCusto;

                // Substituir a linha do arquivo
                linhas[i] = string.Join(",", dados);
                break;
            }
        }

        if (empresaEncontrada)
        {
            // Salvar as linhas de volta no arquivo CSV
            File.WriteAllLines(caminhoArquivo, linhas);
            Console.WriteLine("\nResíduos atualizados com sucesso!");
        }
        else
        {
            Console.WriteLine("\nEmpresa não encontrada.");
        }
    }
}
