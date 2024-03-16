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
            int numeroPedido = int.Parse(Console.ReadLine());

            if(numeroPedido > 0)
            {
                int somatorioImpares = 0;
                for(int contador = 0; contador <= numeroPedido; contador++)
                {
                   if(contador % 2 == 1)
                   {
                     somatorioImpares += contador;
                     
                   }               
                }
                System.Console.WriteLine("O somatorio de todos numeros impares eh: " + somatorioImpares);         
            }
            else if(numeroPedido < 0)
            {
                int quantidadeNegativos = 0;
                for(int contador = 0; contador >= numeroPedido; contador--)
                {
                    if(contador % 2 == 0)
                    {
                        Console.WriteLine(contador);
                    }
                }
            }
            else
            {
                Console.WriteLine("nada a fazer aqui");
            }
		}
	}
}