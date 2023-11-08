using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public  class Artista
    {
        public int ArtistaId { get; set; } 
        public string NomeArte { get; set; }
        public string Biografia { get; set; }
        public string Nazionalita { get; set; }
        public List<ArtistaBrano> ArtistiBrani { get; set; }

    }
}
