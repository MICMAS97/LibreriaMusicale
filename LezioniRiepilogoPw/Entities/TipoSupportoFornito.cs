namespace LezioniRiepilogoPw.Entities
{
   
        public class TipoSupportoFornito
        {
            public int TipoSupportoFornitoId { get; set; } 
            public int QuantitaDisponibile { get; set; }
            public decimal CostoDiAcquisto { get; set; }
            public int SupportoId { get; set; } 
            public int FornitoreId { get; set; } 
        }

}
