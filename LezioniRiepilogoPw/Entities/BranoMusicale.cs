using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class BranoMusicale
    {
        public int BranoId { get; set; } 
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public TimeSpan Durata { get; set; }
        public List<ArtistaBrano> ArtistiBrani { get; set; }
        public int SupportoMusicaleId { get; set; }





    }
}
