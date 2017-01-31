using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;

namespace lm.Oficina.Domain
{
    public abstract class ConexaoBase
    {
        protected string _strConnection = @"Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=C:\Projetos\lm.oficina\DADOS;Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        protected OdbcConnection _connection;

        public abstract bool Conectar();

        public abstract bool Desconectar();    
    }
}
