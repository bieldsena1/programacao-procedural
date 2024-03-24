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
			const int MATRIZ = 8;
			int[,] matriz = new int [MATRIZ, MATRIZ];
		  for(int linha = 0; linha < MATRIZ; linha++)
			{
			  for(int coluna = 0; coluna < MATRIZ; coluna++)
			  {
			    matriz[linha, coluna] = 0;
			  }
			}
			for(int linha = 0; linha < MATRIZ; linha++)
			{
			  for(int coluna = 0; coluna < MATRIZ; coluna++)
			  {
			    matriz[coluna, coluna] = 1;
			    Console.Write(matriz[linha,coluna]);
			  }
			  Console.WriteLine();
			}
		}
	}
}