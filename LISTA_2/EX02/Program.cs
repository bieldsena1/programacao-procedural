using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite as notas do aluno\nNota 1: ");
        double nota1 = double.Parse(Console.ReadLine());
       
        Console.Write("Nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());
       
        Console.Write("Nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());
       
        Console.Write("Nota 4: ");
        double nota4 = double.Parse(Console.ReadLine());

        double mediaAluno = (nota1 + nota2 + nota3 + nota4) / 4;

        if(mediaAluno >= 5)
        {
            Console.Write("Aluno Aprovado");
        }
        else if ((mediaAluno < 5) && (mediaAluno >= 3))
        {
            Console.Write("Aluno em Recuperacao");
        }
        else if (mediaAluno < 3)
        {
            Console.Write("Aluno Reprovado");
        }
        
    }
}
