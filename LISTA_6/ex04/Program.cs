using System;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIZ = 3;
        int[,] numeros = new int[MATRIZ,MATRIZ];
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
                if(linha + coluna == 2)
                {
                    numeros[linha,coluna] *= 2;
                }
                Console.Write(numeros[linha,coluna] + "|");
            }
            System.Console.WriteLine();
        }
        
    }    
}   