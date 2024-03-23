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
			int[] idades = new int [3];
			for(int i = 0; i < 3; i++)
			{
			  idades[i] = int.Parse(Console.ReadLine());
			}
			for(int i = 2; i >= 0; i--)
			{
			  Console.WriteLine(idades[i]);
			}
			
		}
	}
}