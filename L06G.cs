/* Crie um programa que permita o usuário
escolher uma cor(vermelho, azul ou verde)
e exiba uma mensagem informando a cor escolhida. */
using System;

class Program {
  public static void Main (string[] args) {
    // variáveis 
    int op;
    // Menu de opções 
    Console.WriteLine("------------------------------");
   Console.WriteLine("      MENU  DE OPÇÕES         ");
   Console.WriteLine("------------------------------");
   Console.WriteLine("Escolha uma cor: ");
   Console.WriteLine("1. Vermelho");
   Console.WriteLine("2. Azul");
   Console.WriteLine("3. Verde");
   Console.WriteLine("4. Sair");
    // Leitura da opção escolhida
    Console.WriteLine("Digite a opção desejada: ");
   op = Convert.ToInt32(Console.ReadLine());
    // Escolha das opções e saída de dados
   switch (op)
    {
    case 1:
      Console.Write("A cor escolhida foi vermelho.");
      break;
    case 2:
       Console.Write("A cor escolhida foi azul.");
      break;
    case 3:
       Console.Write("A cor escolhida foi verde.");
      break;
      case 4 :
    
      Console.Write("Saiu do programa.");
      break;
    default:
      Console.WriteLine("------------------------------");
   Console.WriteLine("      OPÇÃO INVÁLIDA!!!       ");
   Console.WriteLine("------------------------------");
    break;






      
    }
  }
}