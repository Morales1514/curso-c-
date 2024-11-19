using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*SEMAFARO!!!!!!!*");
     String siga = "AMARELO";

        if(siga == "VERDE"){
            Console.Write("PASSA LOGO");
        }else if(siga == "AMARELO"){
            Console.Write("*ATENÇÃO*");
        }if(siga == "VERMELHO"){
            Console.Write("**PARA !!!!!!!!!!*");
        }



    }
}