using System;

class Program {
  public static void Main (string[] args) {

    //solicitando a nota
      Console.WriteLine("Digite sua nota aluno(0 a 100): ");
    int nota = int.Parse(Console.ReadLine());
    // verificando se a nota é valida
    if (nota >= 0 && nota <= 100){
      // verificando se a nota é aprovada
      if (nota >= 60){
        Console.WriteLine("Parabens,Aprovado.");
      }
      else{
        Console.WriteLine("Reprovado");
      }
    }
    else{
      Console.WriteLine("Nota invalida");
    }
  }
}