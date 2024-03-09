using System;
using System.ComponentModel;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        for(int linha = 0; linha < 8; linha++)
        {
            for(int coluna = 0; coluna < 8; coluna++)
            {
                Tabuleiro.Adicionar(linha, coluna, "biel");
            }
        }
        Tabuleiro.ImprimeTabuleiro();

    }
}