/* Crie um programa que permita ao usuário escolher uma das três opções de tamanho de camiseta(P,M ou G) e exiba o preço correspondente, utilizando o switch. */
using System;

class Program {
  public static void Main (string[] args) {
    // variáveis
    int op;
   // Entrada de dados
   Console.WriteLine("------------------------------");
   Console.WriteLine("      MENU  DE OPÇÕES         ");
   Console.WriteLine("------------------------------");
     Console.WriteLine("Escolha um tamanho de camiseta.");
   Console.WriteLine("1. Tamanho P");
   Console.WriteLine("2.  Tamanho M");
   Console.WriteLine("3.  Tamanho G");
   Console.WriteLine("Digite a opção desejada: ");
   op = Convert.ToInt32(Console.ReadLine());
   switch (op)
    {
    case 1:
      Console.WriteLine("O preço da camiseta P é 20 reais.");
      break;
    case 2:
      Console.WriteLine("O preço da camiseta M é 25 reais.");
      break;
    case 3:
      Console.WriteLine("O preço da camiseta G é 30 reais.");
      break;
    case 4:
    Console.Write("Saiu do programa.");
      break;
    default :
   Console.WriteLine("------------------------------");
   Console.WriteLine("      OPÇÃO INVÁLIDA!!!       ");
   Console.WriteLine("------------------------------");
    break;
      
    }
  }
}