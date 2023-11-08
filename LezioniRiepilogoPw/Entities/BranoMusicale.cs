using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class BranoMusicale
    {

        [Key] 
        public int BranoId { get; set; } 
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public TimeSpan Durata { get; set; }


        public int SupportoMusicaleId { get; set; }

        




    }
}
