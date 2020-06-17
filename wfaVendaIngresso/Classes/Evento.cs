using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVendaIngresso.Classes
{
    public class Evento
    {
        public int id { get; set; }
        public Double valorRecebido { get; set; }
        public Double valorGasto { get; set; }
        public Double valorIngresso { get; set; }
        public Double valorTaxas { get; set; }
        public String nome { get; set; }
        public String endereco { get; set; }
        public DateTime dataHora { get; set; }
        public byte[] imgEvent { get; set; }
    }
}
