using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lm.Oficina.Domain;
using lm.Oficina.DTO;
using System.Data.Odbc;

namespace lm.Oficina.Domain.Repository
{
    class ItensServicoFinalizadoDTORepository
    {
        #region Propriedades

        private string _strSql = string.Empty;

        private ConexaoParadox _conexao;
        private ConexaoParadox conexao
        {
            get { return _conexao ?? (_conexao = new ConexaoParadox()); }
        }

        #endregion

        public void GravarItensServicoFinalizado(ItensServicoFinalizadoDTO ItensServicoFinalizado)
        {
            conexao.Conectar();

            try
            {

                _strSql = "INSERT" +
                                "INTO" +
                          "SERVICOFINALIZADO(CODIGOSERVICOFINALIZADO, CODIGOOSFINALIZADA, DESCRICAODOSERVICO, SERVICOFINALIZADO)" +
                          "VALUES(@CODIGOSERVICOFINALIZADO, @CODIGOOSFINALIZADA, @DESCRICAODOSERVICO, @SERVICOFINALIZADO)";

                OdbcCommand _sqlCmd = new OdbcCommand(_strSql);
                _sqlCmd.Parameters.Add(new OdbcParameter("@CODIGOSERVICOFINALIZADO", ItensServicoFinalizado.CodigoServicoFinalizado));
                _sqlCmd.Parameters.Add(new OdbcParameter("@CODIGOOSFINALIZADA", ItensServicoFinalizado.CodigoOsFinalizada));
                _sqlCmd.Parameters.Add(new OdbcParameter("@DESCRICAOSERVICO", ItensServicoFinalizado.DescricaoDoServico));
                _sqlCmd.Parameters.Add(new OdbcParameter("@SERVICOFINALIZADO", ItensServicoFinalizado.ServicoRealizado));

                _sqlCmd.ExecuteNonQuery();
            }
            catch(Exception eError)
            {
                eError.GetBaseException();
            }
            finally
            {
                conexao.Desconectar();
            }
        }

    }
}
