using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class Fornitore : Utente 
    {
        public string PartitaIVA { get; set; }
        public string Indirizzo { get; set; }
        public List<TipoSupportoFornito> TipiSupportoForniti { get; set; }


    }
}
