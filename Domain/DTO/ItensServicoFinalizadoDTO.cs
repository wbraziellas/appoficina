using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lm.Oficina.Domain.DTO
{
    public class ItensServicoFinalizadoDTO
    {
        public int CodigoServicoFinalizado { get; set; }
        public int CodigoOsFinalizada { get; set; }
        public string DescricaoDoServico { get; set; }
        public bool ServicoRealizado { get; set; }
    }
}
