using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        int tamanhoTabuleiro = 8;
        for(int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
        {
            for(int linha = 0; linha < tamanhoTabuleiro; linha++)
            {
                if(coluna == 0 || coluna == 7 || linha == 0 || linha == 7)
                {
                    Tabuleiro.Adicionar(linha,coluna,"s");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}