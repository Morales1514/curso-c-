using System;

class Program {
  public static void Main (string[] args) {
//ex1 --------------------------
    Console.WriteLine ("Digite alguma coisa no teclado: ");
    String entrada = Console.ReadLine();
    Console.WriteLine("Você digitou: " + entrada);

  //ex2-------------------------
    Console.WriteLine("***********ex2************");
    Console.WriteLine("Digite o primeiro valor: ");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);


      Console.WriteLine("Digite o segundo valor: ");
      string valor2 = Console.ReadLine();
      int numero2 = int.Parse(valor2);

    int soma = numero1 + numero2;

    
       Console.WriteLine("A soma dos valores é: " + soma);
    //ex3-------------------------
    Console.WriteLine("***********ex3************");
    Console.WriteLine("Digite o primeiro valor: ");
    string valor10 = Console.ReadLine();
    int numero10 = int.Parse(valor1);


      Console.WriteLine("Digite o segundo valor: ");
      string valor11 = Console.ReadLine();
      int numero11 = int.Parse(valor2);


    Console.WriteLine("Digite o terceiro valor: ");
    string valor12 = Console.ReadLine();
    int numero12 = int.Parse(valor2);
    
    int media = (numero10 + numero11 + numero12)/3;
       Console.WriteLine("A media dos valores é: " + media);
    }
  }
