using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezioniRiepilogoPw.Entities
{
    public class Cliente : Utente 
    {
        public DateTime DataNascita { get; set; }
        public List<Ordine> Ordini { get; set; }


    }
}
