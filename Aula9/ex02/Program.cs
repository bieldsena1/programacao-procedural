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
			const int NUMEROS_DIGITADOS= 10;
      int quantidadePositivos = 0;
      int quantidadeNegativos = 0;
      int quantidadeZeros = 0;
      int valor = 0;
			
			for(int contador = 0; contador < NUMEROS_DIGITADOS; contador++)
			{
        int numeros = 0;  
			 
			  numeros = int.Parse(Console.ReadLine());

        if(numeros > valor)
        {
          quantidadePositivos++;
        }
        else if(numeros < valor)
        {
          quantidadeNegativos++;
        }
        else if( numeros == valor)
        {
          quantidadeZeros++;
        }
			}
      Console.WriteLine("Numeros positivos: " + quantidadePositivos);
      Console.WriteLine("Numeros negativos: " + quantidadeNegativos);
      Console.WriteLine("Zero(s): " + quantidadeZeros);
	
		}
	}
}