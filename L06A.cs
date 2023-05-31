/*a) Crie um programa que exiba a data e hora atual.*/
using System;

class Program {
  public static void Main (string[] args) {
    // Declaração de variáveis de data
    DateTime dataAtual = DateTime.Now;
    // Imprimir a data na tela
    Console.Write(dataAtual);
  }
}