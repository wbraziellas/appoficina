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
            get { return _conexaoBase ?? (_conexaoBase = new ConexaoParadox()); }
        }
        #endregion

        cone

    }
}
