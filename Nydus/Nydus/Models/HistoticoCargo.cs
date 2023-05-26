using System;

namespace empresa.Models
{
    public class HistoricoCargo
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
