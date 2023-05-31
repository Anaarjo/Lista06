/* Crie um programa que permita ao usuário inserir um número inteiro e exiba uma mensagem
informando se o número é positivo, negativo ou zero */
using System;

class Program {
  public static void Main (string[] args) {
    // variáveis
    int num, op;
    // Menu de opções 
    Console.WriteLine("------------------------------");
   Console.WriteLine("      MENU  DE OPÇÕES         ");
   Console.WriteLine("------------------------------");
   Console.WriteLine("1. Qual o tipo de número inteiro?");
   Console.WriteLine("2. Sair");
    // Entrada de dados
    Console.Write("Digite a opção desejada: ");
   op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
    case 1:
      Console.Write("Por favor, digite um número inteiro: ");
    num = Convert.ToInt32(Console.ReadLine());
      if (num >0)
      {
      Console.WriteLine("O número {0} é positivo.", num);
        }
    
      else if (num < 0)
      {
         Console.WriteLine("O número {0} é negativo.", num);
      }

      else 
      {
        Console.WriteLine("O número {0} é igual a zero.", num);
      }
      break;
    case 2: 
      Console.Write("Você saiu do programa.");
      break;
      default:
     Console.WriteLine("------------------------------");
   Console.WriteLine("      OPÇÃO INVÁLIDA!!!       ");
   Console.WriteLine("------------------------------");
      break;
    }
  }
}