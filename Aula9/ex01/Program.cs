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
			const int NUMEROSOBE = 0;
			const int NUMERODESCE = 50;
			
			for(int contador1 = NUMEROSOBE; contador1 <= NUMERODESCE; contador1++)
			{
			  Console.WriteLine(contador1 + " - " + (NUMERODESCE-contador1));
			}
		}
	}
}