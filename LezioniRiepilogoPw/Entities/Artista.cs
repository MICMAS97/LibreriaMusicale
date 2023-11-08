using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public  class Artista
    {
        [Key]
        public int ArtistaId { get; set; } 
        public string NomeArte { get; set; }
        public string Biografia { get; set; }
        public string Nazionalita { get; set; }

        [ForeignKey("BranoMusicale")]
        public int BranoId { get; set; }

        public Artista(int artistaId, string nomeArte, string biografia, string nazionalita, int branoId)
        {
            ArtistaId = artistaId;
            NomeArte = nomeArte;
            Biografia = biografia;
            Nazionalita = nazionalita;
            BranoId= branoId;
            Console.WriteLine(nomeArte);
        }
    }





}
