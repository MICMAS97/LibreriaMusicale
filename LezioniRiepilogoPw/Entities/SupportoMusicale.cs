using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class SupportoMusicale
    {
        public int SupportoMusicaleId { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public List<BranoMusicale> BraniMusicali { get; set; }

         public override string ToString()
         {
            var br = new StringBuilder();
            foreach(var item in BraniMusicali)
            {
                br.Append(item);

            }

             return $"{Nome}, {Descrizione}, {Prezzo}, {br}";
         }
     
    }
}
