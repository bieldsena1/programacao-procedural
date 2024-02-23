using System;

class Program
{
    static void Main(string[] args)
  {
    Console.Write("DIGITE A ALTURA DO TRIÂNGULO  ");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    Console.Write("DIGITE A BASE DO TRIÂNGULO  ");
    double baseTriangulo = double.Parse(Console.ReadLine());

    double areaTriangulo = (alturaTriangulo*baseTriangulo) / 2;

    Console.WriteLine("A área do triângulo é maior que 20? " + (areaTriangulo >= 20));
   
  }
}
