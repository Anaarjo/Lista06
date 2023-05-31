/*c) Crie um programa que calcule a idade de uma pessoa a partir de sua data de
nascimento. */

using System;

class Program {
  public static void Main (string[] args) {
    
    // Entrada de dados da data de nascimento
   Console.WriteLine("Por favor, digite a sua data de nascimento (MM/dd/yyyy): ");
DateTime dnascimento = DateTime.Parse(Console.ReadLine());
    
    //Cálculo para saber a idade
TimeSpan idade = DateTime.Today - dnascimento;

    // Cálculo para saber a idade em anos de acordo com o salto de um ano para o outro 
    // Por isso utiliza 365.25 e não apenas 365 dias.
int idadeEmAnos = (int) (idade.TotalDays / 365.25); 
    
    // Saída de dados 
Console.WriteLine("Você tem {0} anos.",idadeEmAnos );
  }
}