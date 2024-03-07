using System;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Escreva sua idade para saber o desconto ");
        int idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Qual o valor do oculos ");
        double valorOculos = double.Parse(Console.ReadLine());

        valorOculos -= idade;

        System.Console.WriteLine("Sua idade: " + idade + " valor do oculos com desconto: " + valorOculos);

    }
}