﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero ");
        int numero = int.Parse(Console.ReadLine());

        if(numero %  2 == 0)
        {
            Console.Write("NUMERO EH PAR");
        }
        else
        {
            Console.Write("NUMERO EH IMPAR");
        }
    }
}


