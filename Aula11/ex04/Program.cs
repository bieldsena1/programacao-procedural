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
			string[] nomes = new string[5];
			int[] idades = new int[5];
			bool[] ehCasado = new bool[5];
			
			for(int i = 0; i < 5; i++)
			{
			    nomes[i] = Console.ReadLine();
			    idades[i] = int.Parse(Console.ReadLine());
                ehCasado[i] = bool.Parse(Console.ReadLine()); 
			}
			Console.WriteLine("As pessoas casadas sao:");
            for(int i = 0; i < 5; i++)
            {
                if(ehCasado[i])
                {
                    Console.WriteLine(nomes[i] + ", de " + idades[i] + " anos");
                    
                }
            }
		}
	}
}