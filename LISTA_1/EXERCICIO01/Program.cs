using System;

class Program {
  static void Main (string[] args)
  {
    Console.Write("ESCREVA SEU NOME ");
    string nome = Console.ReadLine();

    Console.Write("ESCREVA SEU SOBRENOME ");
    string sobreNome = Console.ReadLine();

    Console.WriteLine("Prazer " + sobreNome + " " + nome);
  
  }
}