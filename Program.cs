using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno, situacaoAluno;
            int idadeAluno;
            double nota1, nota2, nota3, media;
            
            Console.WriteLine("Digite o nome do(a) aluno(a):");
            nomeAluno = Console.ReadLine() ?? "Nome não reconhecido!";
            
            Console.WriteLine("Digite a idade do(a) aluno(a):");
            idadeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota:");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                situacaoAluno = "Aprovado 🎉";
            }
            else
            {
                situacaoAluno = "Reprovado 😢";
            }

            Console.WriteLine("Nome: " + nomeAluno);
            Console.WriteLine("Idade: " + idadeAluno);
            Console.WriteLine("Notas: " + nota1.ToString("F1", CultureInfo.InvariantCulture) + ", " + nota2.ToString("F1", CultureInfo.InvariantCulture) + ", " + nota3.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Situação do Aluno: " + situacaoAluno);
        }
    }
}
