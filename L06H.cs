/*Crie um programa que permita ao usuário inserir uma letra e exiba se é uma vogal ou consoante. */

using System;

class Program {
  public static void Main (string[] args) {
    // variáveis
    string letra;
    int op;
     // Menu de opções 
    Console.WriteLine("------------------------------");
   Console.WriteLine("      MENU  DE OPÇÕES         ");
   Console.WriteLine("------------------------------");
   Console.WriteLine("1. Digite uma letra e descubra se ela é vogal ou consoante.");
   Console.WriteLine("2. Sair");
    // Entrada de dados e leitura da op escolhida
    Console.Write("Digite a opção desejada: ");
   op = Convert.ToInt32(Console.ReadLine());
    // Saída de dados
    switch (op)
    {
      // caso a pessoa deseja saber se é ou não uma vogal
    case 1:
      Console.Write("Por favor, digite uma letra: ");
      letra = Console.ReadLine().ToLower();
      if ((letra == "a") || (letra == "e")|| (letra == "i") || (letra == "o")             || (letra == "u")       )
      {
        Console.WriteLine("A letra {0} é uma vogal.", letra);
      }
      else 
      {
         Console.WriteLine("A letra {0} é uma consoante.", letra);
      }
      break;
      // Caso a pessoa queira sair do programa
    case 2: 
      Console.Write("Você saiu do programa.");
      break;
      // Por padrão, caso nenhuma opção for escolhida
      default:
     Console.WriteLine("------------------------------");
   Console.WriteLine("      OPÇÃO INVÁLIDA!!!       ");
   Console.WriteLine("------------------------------");
      break;
    }
  }
}