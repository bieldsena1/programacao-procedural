using System;

class Program
{
    static void Main(string[] args)
    {
        
        const int TABUADA = 10;
        for(int numero1 = 0; numero1 <= TABUADA; numero1++)
        {
            Console.WriteLine("\nTabuada do " + numero1);
            for(int numero2 = 0; numero2 <= TABUADA; numero2++)
            {
                Console.Write(numero1 + " X " + numero2 + " = "+ (numero1 * numero2) + "\n");
            }


        }
    }
}