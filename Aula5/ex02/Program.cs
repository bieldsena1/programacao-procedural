using System;

class Program
{
    static void Main(string[] args)
    {
        const double cartaoPresente = 200;
        Console.Write("ESCREVA QUANTO VAI GASTAR: ");
       
        double gasto = double.Parse(Console.ReadLine());
        
        if(gasto > cartaoPresente)
        {
        Console.Write("COMPRA NEGADA");
        }
        else
        {
        Console.Write("COMPRA REALIZADA");
        }
    }
}

