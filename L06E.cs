/*Crie um programa que permita ao usuário escolher uma opção de menu (1, 2
ou 3) e exiba uma mensagem de acordo com a opção escolhida. */

using System;

class Program {
  public static void Main (string[] args) {
    
   // Variáveis
     double op, s,f,m, d_3;


// Entrada de dados
   Console.WriteLine("------------------------------");
   Console.WriteLine("      MENU  DE OPÇÕES         ");
   Console.WriteLine("------------------------------");
   Console.WriteLine("1. Novo salário");
   Console.WriteLine("2. Férias");
   Console.WriteLine("3. Décimo terceiro");
   Console.WriteLine("4. Sair");
   Console.WriteLine("Digite a opção desejada: ");
   op = Convert.ToDouble(Console.ReadLine());
   switch (op)
    {
    case 1 :
      Console.Write("Digite o salário: ");
      s = Convert.ToDouble(Console.ReadLine());
      if  (s<350) {
         s = s + (s * 15/100);
        }
      else if  (s<=600) 
      {
            s = s + (s* 10/100);
           }
        
      else if  (s>600)
         {
               s = s + ( s * 5/100);
          }

      Console.WriteLine("O novo salário séra de " + s);
      break;
    case 2 :
      
      Console.Write("Digite o salário: ");
      s = Convert.ToDouble(Console.ReadLine());
      f = s + ( 1/3 * s);
      Console.Write("O valor de suas férias é igual a " + f);
    break;
      
    case 3 : 
      Console.Write("Digite o salário: ");
      s = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite o número de meses de trabalho na empresa: ");
      m = Convert.ToDouble(Console.ReadLine());
      if (m<=12) {
         d_3 = (s*m)/12;
         Console.WriteLine("O valor do décimo terceiro é igual a" +  d_3);
    }
    else{
         Console.WriteLine("Digite no máximo 12 meses de trabalho.");
      }
    break;
      
    case 4 :
    
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