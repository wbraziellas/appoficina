using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lm.Oficina.DTO
{
    public class DadosServicoDTO
    {
        public int CodigoOs { get; set; }
        public string CodigoCliente { get; set; }
        public string Nomecliente { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataOs { get; set; }
        public string Servico { get; set; }
    }
}
