using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome de usuario: ");
        string nomeUsuario = Console.ReadLine();

        Console.WriteLine("Digite a senha: ");
        string senha = Console.ReadLine();

        if(nomeUsuario == "admin" && senha == "123senha")
        {
            Console.Write("Conectado com Sucesso");
        }
        else
        {
            Console.Write("Login Incorreto");
        }
    }
}
