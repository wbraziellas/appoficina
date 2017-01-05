using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lm.Oficina.Domain;
using System.Linq;

namespace lm.Oficina.Tests
{
    [TestClass()]
    public class ApiTests
    {
        #region Propriedades
        private ConexaoParadox _conexaoParadox;
        private ConexaoParadox conexaoParadox
        {
            get { return _conexaoParadox ?? (_conexaoParadox = new ConexaoParadox()); }
        }
        #endregion

        [TestMethod()]
        public void Testar_Conexao_Paradox()
        {
            var conexao = conexaoParadox.Conectar();
            Assert.IsFalse(conexao, "Não conectou à base!");
        }

    }
}
