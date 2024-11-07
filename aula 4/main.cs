using System;
class Carro{
  //propriedades do carro
  public string Marca{get;set;}
  public string Modelo{get;set;}

  public void ExibirInfo(){
    Console.WriteLine($"Marca: {Marca}  {Modelo}");
  }
}



class Program {
  public static void Main (string[] args) {
    Carro meuCarrro = new Carro();
    meuCarrro.Marca = "VW";
    meuCarrro.Modelo = "Fusca";

    //chamando o metodo do objeto
    meuCarrro.ExibirInfo();
  }
}