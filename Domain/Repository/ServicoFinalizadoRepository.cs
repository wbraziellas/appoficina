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
    public class ServicoFinalizadoRepository
    {
        #region propriedades

        string _strSql = string.Empty;

        private ConexaoParadox _conexao;
        private ConexaoParadox conexao
        {
            get { return _conexao ?? (_conexao = new ConexaoParadox()); }
        }

        #endregion

        public void GravarServicoFinalizado(ServicoFinalizadoDTO servicoFinalizadoDto)
        {
            conexao.Conectar();

            try
            {
                _strSql = "INSERT INTO SERVICOFINALIZADO" +
                                "(CODIGODAOS, NOMECLIENTE, PLACAVEICULO, DATAOS, DATAOSFINALIZADA, MECANICOOS, CODIGOSERVICOFEITO)" +
                                "VALUES(@CODIGODAOS, @NOMECLIENTE, @PLACAVEICULO, @DATAOS, @DATAOSFINALIZADA, @MECANICOOS, @CODIGOSERVICOFEITO)";

                OdbcCommand _sqlCmd = new OdbcCommand(_strSql);
                _sqlCmd.Parameters.Add(new OdbcParameter("@CODIGODAOS", servicoFinalizadoDto.CodigoDaOS));
                _sqlCmd.Parameters.Add(new OdbcParameter("@NOMECLIENTE", servicoFinalizadoDto.NomeCliente));
                _sqlCmd.Parameters.Add(new OdbcParameter("@PLACAVEICULO", servicoFinalizadoDto.PlacaVeiculo));
                _sqlCmd.Parameters.Add(new OdbcParameter("@DATAOS", servicoFinalizadoDto.DataOs));
                _sqlCmd.Parameters.Add(new OdbcParameter("@DATAOSFINALIZADA", servicoFinalizadoDto.DataOsFinalizada));
                _sqlCmd.Parameters.Add(new OdbcParameter("@MECANICOOS", servicoFinalizadoDto.MecanicoOs));
                _sqlCmd.Parameters.Add(new OdbcParameter("@CODIGOSERVICOFEITO", servicoFinalizadoDto.CodigoServicoFeito));

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

        public List<ServicoFinalizadoDTO> SelecionarServicoFinalizado()
        {
            _strSql = "SELECT" +
                            "CODIGODAOS" +
                            "NOMECLIENTE" +
                            "PLACAVEICULO" +
                            "DATAOS" +
                            "DATAOSFINALIZADA" +
                            "MECANICOOS" +
                            "CODIGOSERVICOFEITO" +
                       "FROM SERVICOFINALIZADO";

            conexao.Conectar();

            try
            {
                OdbcCommand _strCmd = new OdbcCommand(_strSql);

                var adapter = new OdbcDataAdapter() { SelectCommand = _strCmd };
                var data = new DataTable();

                adapter.Fill(data);
                return ConverterDataEmServicoFinalizado(data);

            }
            catch(Exception eError)
            {
                return new List<ServicoFinalizadoDTO>();
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        #region Métodos Privados

        private List<ServicoFinalizadoDTO> ConverterDataEmServicoFinalizado(DataTable data)
        {
            var listaServico = new List<ServicoFinalizadoDTO>();

            foreach(DataRow row in data.Rows)
            {
                var servico = new ServicoFinalizadoDTO();
                var linha = row.ItemArray;

                servico.CodigoDaOS = int.Parse(linha[0].ToString());
                servico.NomeCliente = linha[1].ToString();
                servico.PlacaVeiculo = linha[2].ToString();
                servico.DataOs = DateTime.Parse(linha[3].ToString());
                servico.DataOsFinalizada = DateTime.Parse(linha[4].ToString());
                servico.MecanicoOs = linha[5].ToString();
                servico.CodigoServicoFeito = int.Parse(linha[6].ToString());

                listaServico.Add(servico);
            }

            return listaServico;
        }

        #endregion
    }
}
