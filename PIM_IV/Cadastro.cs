using System;
using System.Collections.Generic;
using System.IO;

public static class Cadastro
{
    private static string caminhoArquivo = "empresas.csv";

    public static void CadastrarEmpresa()
    {
        Console.WriteLine("=== Cadastro de Empresa ===");

        // Informações da empresa
        Console.Write("Nome do Responsável: ");
        string nomeResponsavel = Console.ReadLine();

        Console.Write("Nome da Empresa: ");
        string nomeEmpresa = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        // Informações de resíduos
        Console.Write("Quantidade de Resíduos Ambientais Tratados: ");
        string quantidadeResiduos = Console.ReadLine();

        Console.Write("Período: ");
        string periodo = Console.ReadLine();

        Console.Write("Custo: ");
        string custo = Console.ReadLine();

        // Salvar no CSV
        string linha = $"{nomeResponsavel},{nomeEmpresa},{telefone},{endereco},{email},{quantidadeResiduos},{periodo},{custo}";
        File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);

        Console.WriteLine("\nCadastro realizado com sucesso!");
    }
}
