using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

public static class Login
{
    // Banco de dados fictício
    static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        { "usuario1", GerarHash("senha123") },
        { "admin", GerarHash("admin@123") }
    };

    public static bool RealizarLogin() // Removido o duplicado 'static'
    {
        Console.WriteLine("=== Tela de Login ===");

        Console.Write("Usuário: ");
        string usuario = Console.ReadLine();

        Console.Write("Senha: ");
        string senha = LerSenha();

        // Criptografar a senha fornecida
        string senhaHash = GerarHash(senha);

        // Validar credenciais
        if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senhaHash)
        {
            Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, " + usuario + "!");
            return true;
        }
        else
        {
            Console.WriteLine("\nUsuário ou senha inválidos.");
            return false;
        }
    }

    // Função para gerar o hash da senha
    static string GerarHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder resultado = new StringBuilder();
            foreach (byte b in bytes)
            {
                resultado.Append(b.ToString("x2"));
            }
            return resultado.ToString();
        }
    }

    // Função para ler a senha sem exibi-la no console
    static string LerSenha()
    {
        StringBuilder senha = new StringBuilder();
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }
            else if (tecla.Key == ConsoleKey.Backspace)
            {
                if (senha.Length > 0)
                {
                    senha.Remove(senha.Length - 1, 1);
                    Console.Write("\b \b");
                }
            }
            else
            {
                senha.Append(tecla.KeyChar);
                Console.Write("*");
            }
        }
        return senha.ToString();
    }
}
