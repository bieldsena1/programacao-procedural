using System;

class Program
{
    static void Main(string[] args)
    {
        const int VETOR = 10;
        int[] numeros = new int[VETOR];
        int contador = 0;
        while(contador < VETOR)
        {
            int numeroEscolhido = int.Parse(Console.ReadLine());
            if(numeroEscolhido >= 10 && numeroEscolhido <=50)
            {
                numeros[contador] = numeroEscolhido;
                contador++;
            }
            
        }
        for(int linha = 0; linha < VETOR; linha++)
        {
            Console.WriteLine(numeros[linha]);
        }
        
    }    
}   