using System;

class Program
{
    static void Main(string[] args)
    {
        const int VETOR = 10;
        string[] nomes = new string[VETOR];

        for(int i = 0; i < VETOR; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        for(int i = VETOR - 1; i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}