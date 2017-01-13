using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lm.Oficina.Domain;
using lm.Oficina.DTO;
using System.Data.Odbc;
using System.Data;

namespace lm.Oficina.Domain.Repository
{
    class ItensServicoFinalizadoRepository
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

        public List<ItensServicoFinalizadoDTO> SelecionarItensServicoFinalizado(int IdServico)
        {
            conexao.Conectar();

            _strSql = "SELECT" +
                            "CODIGOSERVICOREALIZADO" +
                            "CODIGOOSFINALIZADA" +
                            "DESCRICAODOSERVICO" +
                            "SERVICOREALIZADO" +
                       "FROM ITENSSERVICOFINALIZADO" + 
                       "WHERE" +
                             "CODIGOOSFINALIZADA = @CODIGOOSFINALIZADA";

            OdbcCommand _strCmd = new OdbcCommand(_strSql);
            _strCmd.Parameters.Add(new OdbcParameter("@CODIGOOSFINALIZADA", IdServico));

            var adapter = new OdbcDataAdapter() { SelectCommand = _strCmd };
            var data = new DataTable();

            adapter.Fill(data);

            return ConverterDataEmItensServicoFinalizadoDTO(data);            
        }

        #region Métodos Privados

        private List<ItensServicoFinalizadoDTO> ConverterDataEmItensServicoFinalizadoDTO(DataTable data)
        {
            var listaItens = new List<ItensServicoFinalizadoDTO>();

            foreach(DataRow row in data.Rows)
            {
                var Item = new ItensServicoFinalizadoDTO();
                var linha = row.ItemArray;

                Item.CodigoServicoFinalizado = int.Parse(linha[0].ToString());
                Item.CodigoOsFinalizada = int.Parse(linha[1].ToString());
                Item.DescricaoDoServico = linha[2].ToString();
                Item.ServicoRealizado = bool.Parse(linha[3].ToString());

                listaItens.Add(Item);
            }

            return listaItens;
        }

        #endregion

    }
}
