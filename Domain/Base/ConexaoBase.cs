﻿using System;
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
        protected string _strConnection = @"Microsoft dBASE Driver (*.dbf)};DriverID=277;Dbq=C:\Projetos\lm.oficina\DADOS";
        protected OdbcConnection _connection;

        public abstract bool Conectar();

        public abstract bool Desconectar();    
    }
}
