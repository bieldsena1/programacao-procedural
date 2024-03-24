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
			const int MATRIZ = 3;
	    	char[,] numeros = new char [MATRIZ,MATRIZ];		
			for(int linha = 0; linha < MATRIZ; linha++)
			{
			  for(int coluna = 0; coluna < MATRIZ; coluna++)
			  {
			    char letra = char.Parse(Console.ReadLine());
			    numeros[linha, coluna] = letra;
			  }
			}
			for(int linha = 2; linha >= 0; linha--)
			{
				for(int coluna = 2; coluna >= 0; coluna--)
				{
					Console.WriteLine(numeros[linha,coluna]);
				}
				Console.WriteLine();
			}
			
		}
	}
}