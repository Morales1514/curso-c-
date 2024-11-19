using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Calcule a área do retângulo");
    Console.WriteLine("Digite o valor da base:");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);

    Console.WriteLine("Digite a altura:");
    string valor2 = Console.ReadLine();
    int numero2 = int.Parse(valor2);


    int multiplicacao = numero1 * numero2;


    Console.WriteLine("Area é: " + multiplicacao);
  }
}