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
		  int[] numerosPares = new int[5];
          int contador = 0;
	      while(contador < 5)
	      {
	        int numero = int.Parse(Console.ReadLine()); 
	       
	        if(numero % 2 == 0)
	        {
              numerosPares[contador] = numero;
              contador++;
	        }   
	      }
          for(contador = 0; contador < 5; contador++)
          {
            Console.WriteLine(numerosPares[contador]);
          }
	    }
	}
}