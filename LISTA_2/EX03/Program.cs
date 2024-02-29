using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite 1 para rotina de Filomena ou digite 2 para rotina de Joselito");
        int rotina = int.Parse(Console.ReadLine());

        if(rotina == 1)
        {
            Console.Write(" ROTINA FILOMENA\n1. Escola das 07h as 12h\n"
            + "2. Almoço das 12h as 13h\n"
            + "3. Futebol das 14h as 16h\n"
            + "4. Dever de casa das 16h as 18h");
        }
        else if(rotina == 2)
        {
            Console.Write(" ROTINA JOSELITO\n1. Escola das 07h as 12:30h\n"
            + "2. Almoço das 13h as 14h\n"
            + "3. Natação das 14h as 16h\n"
            + "4. Reforço escolar das 16h as 19h");
        }
        else
        {
            Console.Write("Rotina nao identificada");
        }
    }
}
