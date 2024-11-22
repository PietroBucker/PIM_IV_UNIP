using System;

class Program
{
    static void Main(string[] args)
    {
        // Chamada para o método de login
        if (Login.RealizarLogin())
        {
            Console.WriteLine("Bem-vindo ao sistema!");
            Menu.ExibirMenu();
            // Aqui, você pode chamar o menu principal ou outras funcionalidades.
        }
        else
        {
            Console.WriteLine("Encerrando o sistema...");
        }
    }
}
