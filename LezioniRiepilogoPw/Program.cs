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

        Artista artista1 = new Artista
        {
            NomeArte = "Pupo",
            Biografia = "E' un cantante italiano.",
            Nazionalita = "Italiana",
            ArtistiBrani = new List<ArtistaBrano>
            {
                new ArtistaBrano
                {
                    ArtistaId = 1,
                    BranoId = 1
                }



            }


        };


        BranoMusicale branoMusicale = new BranoMusicale
        {


        };









  
        Console.WriteLine("Dettagli del CD:");
        Console.WriteLine($"Nome: {cd1.Nome}");
        Console.WriteLine($"Descrizione: {cd1.Descrizione}");
        Console.WriteLine($"Prezzo: {cd1.Prezzo:C}"); 
        Console.WriteLine($"Numero di tracce: {cd1.NumeroTracce}");
    }

    


}
 