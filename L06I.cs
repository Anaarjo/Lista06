/*Crie um programa que leia um número de 1 a 7
e exiba o dia da semana correspondente, 
utilizando o switch */
using System;

class Program {
  public static void Main (string[] args) {
    // variáveis
    int op;
   Console.WriteLine("Qual é o dia da semana? Digite um número de 1 a 7.");
    // Entrada de dados
    Console.Write("Digite a opção desejada: ");
   op = Convert.ToInt32(Console.ReadLine());
    // Saída de dados de acordo com o caso escolhido 
    switch (op)
    {
    case 1:
      Console.WriteLine("Segunda");
      break;
    case 2:
      Console.WriteLine("Terça");
      break;
    case 3:
      Console.WriteLine("Quarta");
      break;
    case 4:
      Console.WriteLine("Quinta");
      break;
    case 5:
      Console.WriteLine("Sexta");
      break;
    case 6:
      Console.WriteLine("Sábado");
      break;
    case 7:
      Console.WriteLine("Domingo");
      break;
    default: 
      Console.WriteLine("Opção inválida!!");
      break;
    }
  }
}