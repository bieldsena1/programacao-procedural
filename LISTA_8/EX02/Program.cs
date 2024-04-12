﻿using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        const int VETOR = 4;
        Produto[] produtos = new Produto[VETOR];

        for (int i = 0; i < 4; i++)
        {
            produtos[i].id = int.Parse(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = double.Parse(Console.ReadLine());
            produtos[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for(int i = 0; i < 4; i++)
        {
            if(produtos[i].disponivelEmEstoque)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco);
            }
        }
    }
}