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
			string[] nomes = new string[4];
            for(int i = 0; i < 4; i++)
            {
                nomes[i] = Console.ReadLine();
            }
            bool temJose = false;
            for(int i= 0; i < 4; i++)
            {
                if(nomes[i] == "Jose")
                {
                    temJose = true;
                }
            }
            if(temJose)
            {
                Console.WriteLine("Jose foi encontrado na lista");
            }
            else
            {
                Console.WriteLine("Jose nao foi encontrado na lista");
            }
		}
	}
}