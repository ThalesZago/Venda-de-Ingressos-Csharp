using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVendaIngresso.Classes
{
    public class Ingresso
    {
        public int id { get; set; }
        public double valor { get; set; }
        public string formaPagamento { get; set; }
        public int idEvento { get; set; }
        public String cpfPessoa { get; set; }
        public String nomeEvento { get; set; }
        public DateTime dataHoraEvento { get; set; }
        public String enderecoEvento { get; set; }
        public int quantidade { get; set; }
        public byte[] imgEvent { get; set; }
    }
}
