using System;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIZ = 4;
        int[,] numeros = new int[MATRIZ,MATRIZ];
        int somatorio = 0;
        for(int linha = 0; linha < MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ; coluna++)
            {
                numeros[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
        int escolhaNumero = int.Parse(Console.ReadLine());
        if(escolhaNumero == 1)
        {
            for(int linha = 0; linha < MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < MATRIZ; coluna++)
                {
                    Console.WriteLine(numeros[linha,coluna]);
                }
            }
        }
        
        else if(escolhaNumero == 2)
        {
            for(int linha = 0; linha < MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < MATRIZ; coluna++)
                {
                    somatorio += numeros[linha,coluna];
                }
            }
            Console.Write(somatorio);
        }
        else if(escolhaNumero == 3)
        {
            for(int linha = 0; linha < MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < MATRIZ; coluna++)
                {
                    if(coluna % 2 == 0)
                    {
                        somatorio+= numeros[linha,coluna];
                    }
                }
            }     
            Console.Write(somatorio);
        }
        else if(escolhaNumero == 4)
        {
            for(int linha = 0; linha < MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < MATRIZ; coluna++)
                {
                    if(linha == coluna)
                    {
                        somatorio += numeros[linha,coluna];
                    }
                }
            }
            Console.Write(somatorio);
        }
        else if(escolhaNumero == 5)
        {
            for(int linha = 0; linha < MATRIZ; linha++)
            {
                for(int coluna = 0; coluna < MATRIZ; coluna++)
                {
                    if(linha == 1  && coluna % 2 == 0)
                    {
                        somatorio += numeros[linha,coluna];
                    }
                }
            }
            Console.Write(somatorio);
        }
    }    
}   