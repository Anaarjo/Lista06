using System;
using System.Collections.Generic; 
class Program {
  public static void Main (string[] args) {
    // Lista contendo os feriados nacionais do BR
List<DateTime> feriadosNacionais = new List<DateTime>()
{
    new DateTime(DateTime.Now.Year, 1, 1),   // Confraternização Universal
    new DateTime(DateTime.Now.Year, 4, 21),  // Tiradentes
    new DateTime(DateTime.Now.Year, 5, 1),   // Dia do Trabalho
    new DateTime(DateTime.Now.Year, 9, 7),   // Independência do Brasil
    new DateTime(DateTime.Now.Year, 10, 12), // Nossa Senhora Aparecida
    new DateTime(DateTime.Now.Year, 11, 2),  // Finados
    new DateTime(DateTime.Now.Year, 11, 15), // Proclamação da República
    new DateTime(DateTime.Now.Year, 12, 25)  // Natal
};
// Entrada de dados
Console.WriteLine("Por favor, digite a  data de  (MM/dd/yyyy): ");
    
 DateTime dataDesejada = DateTime.Parse(Console.ReadLine());
    
// Saída de dados 
// Mostra se é feriado ou não
bool ehFeriadoNacional = feriadosNacionais.Contains(dataDesejada);
  Console.Write(ehFeriadoNacional);




    
    }
  }