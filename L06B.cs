/*b) Crie um programa que calcule a diferença em dias entre duas datas. */
using System;

class Program {
  public static void Main (string[] args) {
  
    // Declaração de variáveis de data
    int mes1, dia1, ano1, mes2, dia2, ano2;
    
    //Entrada de dados da 1º data
    
    Console.Write("Por favor digite um mês: ");
 mes1= int.Parse(Console.ReadLine());
Console.Write("Por favor digite o dia (em forma de número): ");
 dia1 = int.Parse(Console.ReadLine());
Console.Write("Por favor, digite o ano: ");
ano1 = int.Parse(Console.ReadLine());
  Console.Clear();
    
         // Formatação da 1º data
    
DateTime pdata = new DateTime(ano1, mes1, dia1);
    
    // Esse formato é de dia/ mês/ ano
    
    string dataFormatada = pdata.ToString("dd/MM/yyyy");
    
    // Entrada de dados da 2º data
    
    Console.Write("Agora a segunda data, por favor digite o mês: ");
 mes2= int.Parse(Console.ReadLine());
Console.Write("Por favor digite o dia (em forma de número): ");
 dia2 = int.Parse(Console.ReadLine());
Console.Write("Por favor, digite o ano: ");
ano2 = int.Parse(Console.ReadLine());
  Console.Clear();  
    
// Formatação da 2º data
DateTime segundaData = new DateTime(ano2, mes2, dia2);
    
    // Esse formato é de dia/ mês/ ano
    string sdataFormatada = segundaData.ToString("dd/MM/yyyy");
    
    // Cálculo de subtrair utiliza o  TimeSpan e o Subtract
    // A sintaxe é TimeSpan nome_var = 2data.Subtract (1data);
    
    TimeSpan diferenca = segundaData.Subtract(pdata);
    
    // Saída de dados 
   Console.WriteLine("A diferença entre a data {0} e a data {1} é de {2} dia(s).", dataFormatada,sdataFormatada, Math.Abs(diferenca.TotalDays));

  }
}