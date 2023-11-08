using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class Ordine
    {
        public int OrdineId { get; set; } // Chiave primaria
        public DateTime DataOra { get; set; }
        public string MetodoPagamento { get; set; }
        public string IndirizzoSpedizione { get; set; }
        public string Stato { get; set; }
        public List<OrdineSupporto> SupportiAcquistati { get; set; }
        public int ClienteId { get; set; } // Chiave straniera
    }
}
