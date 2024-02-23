using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.Write("DIGITE QUANTOS CENTAVOS VOCÊ QUER CONVERTER EM REAIS ");
    double centavos = double.Parse(Console.ReadLine());

    double real = (centavos / 100);

    double restoCentavos = (centavos % 100);

    Console.WriteLine("Aqui tem " + real + " Reais" + 
      " e " + restoCentavos + " centavos" );
  }
}