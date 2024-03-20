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
			int contador1 = -2;
			int contador2 = 204;
			
			while(contador1 < 100 && contador2 > 0)
			{
			  if(contador1 % 2 == 0)
  			  {
  			    contador1+=2;
  			  }
  			if (contador2 % 4 == 0)
  			{
  			  contador2 -=4;
  			}
			  
			  Console.Write(contador1 + " - " + contador2 + "\n");
			}
		}
	}
}