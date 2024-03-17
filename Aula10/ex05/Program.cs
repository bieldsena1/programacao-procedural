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
			for(int contador1 = 9; contador1 >= 1; contador1--)
			{
			  for(int contador2 = 1; contador2 <= contador1; contador2++)
        {
          Console.Write(contador2);
        }
        Console.WriteLine();
			}
		}
	}
}