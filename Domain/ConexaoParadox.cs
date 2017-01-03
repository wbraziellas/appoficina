using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace lm.Oficina.Domain
{
    public class ConexaoParadox : ConexaoBase
    {
        public override bool Conectar()
        {
            _connection = new OdbcConnection(_strConnection);
            try
            {

                if (ConnectionState.Closed == _connection.State)
                {
                    _connection.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OdbcException eError)
            {
                throw eError;
            }
        }
    }
}
