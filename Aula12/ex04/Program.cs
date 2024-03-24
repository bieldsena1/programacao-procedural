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
			string[,] dados = new string[4,3];
			for(int linha = 0; linha < 4; linha++)
			{
			 for(int coluna = 0; coluna < 3; coluna++)
			 {
			   string dadoPessoa = Console.ReadLine();
			   dados[linha,coluna] = dadoPessoa;
			 }
			}
			for(int linha = 3; linha >= 0 ; linha--)
			{
			 for(int coluna = 0; coluna < 3; coluna++)
			 {
			   Console.WriteLine(dados[linha,coluna]);
			 }
			}
		}
	}
}