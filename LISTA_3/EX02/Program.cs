using System;

class Program
{
    static public void Main(string[] args)
    {
        System.Console.Write("Quantidade de itens comprados: ");
        int quantidadeItensComprados = int.Parse(Console.ReadLine());
        int contador = 0;
        double valorItens;
        double somatorioItens = 0;

        while(contador < quantidadeItensComprados)
        {
            contador++;
            System.Console.Write("Qual o valor do item " + contador + ": ");
            valorItens = double.Parse(Console.ReadLine());
            somatorioItens += valorItens;
            
        }
        if(somatorioItens >= 150)
        {
            System.Console.Write("Voce tera frete gratis em sua compra :)\no valor da sua conta foi de: " + somatorioItens );
        }
        else
        {
            System.Console.Write("Voce nao tera frete gratis em sua compra :(\no valor da sua conta foi de: " + somatorioItens);
        }
    }
}