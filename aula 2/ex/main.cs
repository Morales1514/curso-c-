using System;

class Program
{
    public static void Main(string[] args)
    {
        const double precoTotal = 20.00;
        double precoFinal = 0;
        //informando a idade do comprador 
        Console.Write("Informe a idade do comprador: ");
        int idade = int.Parse(Console.ReadLine());

        //condicoes do desconto
        if (idade < 5)
        {
            precoFinal = 0;
        }
        else if (idade >= 5 && idade <= 12)
        {
            precoFinal = precoTotal * 0.5;
        }
        else if (idade >= 13 && idade <= 60)
        {
            precoFinal = precoTotal;
        }
        else if (idade > 60)
        {
            precoFinal = precoTotal * 0.7;
        }
      Console.WriteLine($"O preço final é: R$ {precoFinal:F2}");
    }
}