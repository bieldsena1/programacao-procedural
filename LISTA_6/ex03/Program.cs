using System;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIZ = 3;
        int[,] numeros = new int[MATRIZ,MATRIZ];
        int soma = 0;
        for(int linha = 0; linha < MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ; coluna++)
            {
                numeros[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }

        for(int linha = 0; linha < MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ; coluna++)
            {
                if(linha == coluna)
                {
                    soma +=numeros[linha,coluna];
                }
            }
        }
        Console.Write(soma);
    }
}  