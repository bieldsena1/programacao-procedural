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
			const string LINHA = "*";
      const string COLUNA = "*";
      int linhaPedida = int.Parse(Console.ReadLine());
      int colunaPedida = int.Parse(Console.ReadLine());
      for(int contador1 = 1; contador1 <= linhaPedida; contador1++)
      {
       for(int contador2 = 1; contador2 < colunaPedida; contador2++)
        {
           Console.Write(LINHA);
        }
        Console.WriteLine(COLUNA);
      }  
		}
	}
}