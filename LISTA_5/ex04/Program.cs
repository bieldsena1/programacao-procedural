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
			
			while(true)
			{
			  int numeroPedidos = int.Parse(Console.ReadLine());
			  
			  if(numeroPedidos < 0)
			  {
			    break;
			  }
			  else if(numeroPedidos % 2 != 0)
			  {
			    somatorio += numeroPedidos;
			  }
			  
			}
			Console.WriteLine("O somatorio de impares eh: " + somatorio);
		}
	}
}