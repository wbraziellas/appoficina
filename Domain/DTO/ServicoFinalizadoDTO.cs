using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lm.Oficina.Domain.DTO
{
    public class ServicoFinalizadoDTO
    {
        public int CodigoDaOS { get; set; }
        public string NomeCliente { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataOs { get; set; }
        public DateTime DataOsFinalizada { get; set; }
        public string MecanicoOs { get; set; }
        public int CodigoServicoFeito { get; set; }
    }
}
