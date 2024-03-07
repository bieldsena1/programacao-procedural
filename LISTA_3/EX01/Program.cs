using System;
class Program
{
    static public void Main(string[] args)
    {
        double maiorSalario = 0;
        double somatorioSalario = 0;
        double somatorioFilhos = 0;
        double mediaFilhos;
        double mediaSalario;
        System.Console.WriteLine("Quantas pessoas irão participar dessa pesquisa? ");
        int pessoas = int.Parse(Console.ReadLine());
        for(int i = 1; i <= pessoas; i++)
        {
            System.Console.WriteLine("Qual seu salário pessoa " + i + ": ");
            double salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantos filhos voce tem? ");
            int filhos = int.Parse(Console.ReadLine());

            somatorioFilhos = somatorioFilhos + filhos;
            somatorioSalario = somatorioSalario + salario;
            if(salario > maiorSalario)
            {
                maiorSalario = salario;

            }
        }
        mediaFilhos = somatorioFilhos / pessoas;
        mediaSalario = somatorioSalario / pessoas;

        Console.Write("Media de filhos: " + mediaFilhos + "\nMedia salarial: " + mediaSalario + "\nMaior salario: " + maiorSalario);


    }
}
