using System;

class Program
{
    static void Main(string[] args)
    {
        int contadorTentivas = 0;
        do
        {
            System.Console.Write("Escreva o nome de usuario: ");
            string usuario = Console.ReadLine();
            System.Console.Write("Escreva a senha: ");
            string senha = Console.ReadLine();

            if(usuario == "admin" && senha == "123senha")
            {
                System.Console.WriteLine("Login realizado com sucesso!! ");
                break;
            }
            contadorTentivas++;
            if(contadorTentivas == 3)
            {
                System.Console.WriteLine("conta bloqueada");
            }
        }
        while(contadorTentivas < 3);
       
    }
}