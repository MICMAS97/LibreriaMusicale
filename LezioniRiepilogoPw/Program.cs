using LezioniRiepilogoPw.Entities;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        CD cd1 = new CD
        {
            Nome = "CD1",
            Descrizione = "CD di esempio",
            Prezzo = 15.99M,
            NumeroTracce = 12
        };

        SupportoMusicale supportoMusicale = new SupportoMusicale

        {
        



        };




        
        Console.WriteLine("Dettagli del CD:");
        Console.WriteLine($"Nome: {cd1.Nome}");
        Console.WriteLine($"Descrizione: {cd1.Descrizione}");
        Console.WriteLine($"Prezzo: {cd1.Prezzo:C}"); 
        Console.WriteLine($"Numero di tracce: {cd1.NumeroTracce}");
    }

    


}
 