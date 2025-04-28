using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int anoAtual = 2024;
        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Você tem {idade} anos.");
    }
}