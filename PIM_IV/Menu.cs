using System;

public static class Menu
{
    public static void ExibirMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Cadastrar Empresa");
            Console.WriteLine("2. Atualizar Resíduos");
            Console.WriteLine("3. Mostrar Relatórios");
            Console.WriteLine("4. Baixar Arquivo CSV");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Cadastro.CadastrarEmpresa();
                    break;
                case "2":
                    AtualizacaoResiduos.AtualizarResiduos();
                    break;
                case "3":
                    Relatorios.MostrarRelatorios();
                    break;
                case "4":
                    Relatorios.BaixarCSV();
                    break;
                case "5":
                    Console.WriteLine("Saindo do sistema...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
