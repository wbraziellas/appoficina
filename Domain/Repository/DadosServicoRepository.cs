using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lm.Oficina.DTO;
using lm.Oficina.Domain;
using System.Data.Odbc;
using System.Data;

namespace lm.Oficina.Domain
{
    public class DadosServicoRepository
    {
        #region Propriedades
        private ConexaoParadox _conexaoParadox;
        private ConexaoParadox conexaoParadox
        {
            get { return _conexaoParadox ?? (_conexaoParadox = new ConexaoParadox()); }
        }
        #endregion

        public List<DadosServicoDTO> SelecionarServico()
        {
            conexaoParadox.Conectar();

            return new List<DadosServicoDTO>();
        }
    }
}
