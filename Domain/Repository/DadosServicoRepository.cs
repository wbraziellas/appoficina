using System;
using System.Collections.Generic;
using lm.Oficina.DTO;
using System.Data.Odbc;
using System.Data;

namespace lm.Oficina.Domain
{
    public class DadosServicoRepository
    {
        #region Propriedades
        private string _strSql;

        private ConexaoParadox _conexaoParadox;
        private ConexaoParadox conexaoParadox
        {
            get { return _conexaoParadox ?? (_conexaoParadox = new ConexaoParadox()); }
        }
        #endregion

        public List<DadosServicoDTO> SelecionarServico()
        {
            _strSql = @"";
                
            conexaoParadox.Conectar();

            OdbcCommand _cmdSql = new OdbcCommand(_strSql);
            OdbcDataAdapter _adpSql = new OdbcDataAdapter() { SelectCommand = _cmdSql };
            DataTable _data = new DataTable();

            _adpSql.Fill(_data);

            conexaoParadox.Desconectar();

            return ConverterEmDadosServicoDto(_data);
        }

        #region Métodos privados
        private List<DadosServicoDTO> ConverterEmDadosServicoDto(DataTable data)
        {
            var _listaServico = new List<DadosServicoDTO>();

            foreach(DataRow linha in data.Rows)
            {
                var _valorLinha = linha.ItemArray;
                var _dadosServico = new DadosServicoDTO();

                _dadosServico.CodigoOs = int.Parse(_valorLinha[0].ToString());
                _dadosServico.DataOs = DateTime.Parse(_valorLinha[1].ToString());

                _listaServico.Add(_dadosServico);
                
            }

            return _listaServico;
        }
        #endregion
    }
}
