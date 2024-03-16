using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escolha o tamanho da piramide de numero de 1 a 9: ");
        int tamanhoLinha = int.Parse(Console.ReadLine());
        while(tamanhoLinha < 1 || tamanhoLinha > 9)
        {
            System.Console.WriteLine("altura invalida, insira uma altura de 1 a 9" );
            tamanhoLinha = int.Parse(Console.ReadLine());
        }
       for(int linha = 1; linha <= tamanhoLinha; linha++)
        {
            for(int numero = 1; numero <= linha; numero++)
            {
                System.Console.Write(numero);
            }
            System.Console.WriteLine();
        }
         
    }
}
