using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ESCREVA A PRIMEIRA IDADE ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.Write("ESCREVA A SEGUNDA IDADE ");
        int idade2 = int.Parse(Console.ReadLine());

        Console.Write("ESCREVA A TERCEIRA IDADE ");
        int idade3 = int.Parse(Console.ReadLine());

        if(idade1 > idade2 && idade1 > idade3)
        {
            Console.Write("PRIMEIRA IDADE EH A MAIOR QUE EH " + idade1 );
        }
        else if(idade2 > idade1 && idade2 > idade3)
        {
            Console.Write("SEGUNDA IDADE EH A MAIOR QUE EH " + idade2);
        }
        else if(idade3 > idade1) && (idade3 > idade2)
        {
            Console.Write("TERCEIRA IDADE EH A MAIOR QUE EH " + idade3);
        }

    }
}

