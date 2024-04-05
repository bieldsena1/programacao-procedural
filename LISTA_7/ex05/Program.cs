﻿using System;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIZ = 4;
        int[,] matriz = new int[MATRIZ,MATRIZ];

        PreencherMatriz(matriz);

        if(VerificarBalistas(matriz))
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("nao ha balistas no tabuleiro");
        }
    }
    static void PreencherMatriz(int[,] matriz)
    {
        const  int MATRIZ = 4;

        for(int linha = 0; linha < MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ; coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
    }

    static bool VerificarBalistas(int[,] matriz)
    {
        const  int MATRIZ = 4;

        for(int linha = 0; linha < MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < MATRIZ; coluna++)
            {
                if(matriz[linha,coluna] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}