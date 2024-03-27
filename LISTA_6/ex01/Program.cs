using System;
   class Program
   {
    public static void Main(string[] args)
    {
      const int VETOR = 3;
      string[] nomes = new string[VETOR];

      for(int i = 0; i < VETOR; i++)
      {
       nomes[i] = Console.ReadLine();
      }
      string nomeProcurado = Console.ReadLine();
      bool nome = false;
      for(int i = 0; i < VETOR; i++)
      {
        if(nomes[i] == nomeProcurado)
        {
          nome = true;
        }
      } 
      if(nome)
      {
        Console.Write("ACHEI");
      }
      else
      {
        Console.Write("NAO ACHEI");
      }
    }
  }
