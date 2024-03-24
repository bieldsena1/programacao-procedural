using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			const int TAMANHO_NUMEROS = 4;
			int[,] matriz = new int[TAMANHO_NUMEROS,TAMANHO_NUMEROS];
            int somatorio = 0;
            for(int linha = 0; linha < TAMANHO_NUMEROS; linha++)
            {
                for(int coluna = 0; coluna < TAMANHO_NUMEROS; coluna++)
                {
                    int numeros = int.Parse(Console.ReadLine());
                    matriz[linha,coluna] = numeros;
                    somatorio += numeros;
                }
            } 
            
            Console.Write(somatorio);
		}
	}
}