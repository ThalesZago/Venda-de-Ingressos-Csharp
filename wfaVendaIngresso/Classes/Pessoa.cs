using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaVendaIngresso.Classes
{
    abstract class Pessoa
    {
        public String cpf { get; set; }
        public int idUsuario { get; set; }
        public String tipo { get; set; }
        public DateTime dataNascimento { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }
        public String endereco { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
    }
}
