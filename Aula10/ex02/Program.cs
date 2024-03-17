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
			int somatorio = 0;
			for(int contador = 0; contador < 5; contador++)
			{
			  int numeroPedido = int.Parse(Console.ReadLine());
			  if(numeroPedido < 0)
			  {
			    break;
			  }
			  else if(numeroPedido > 0)
			  {
			    somatorio += numeroPedido;
			  }
			}
			Console.Write("O somatorio eh: " + somatorio);
		}
	}
}