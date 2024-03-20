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
			for(int i = 10; i >=1; i--)
			{
			  for(int j = 0; j <= 10; j++)
			  {
			    Console.WriteLine( i + " x " + j + " = "  + j*i );
			  }
			  Console.WriteLine();
			}
			
		}
	}
}