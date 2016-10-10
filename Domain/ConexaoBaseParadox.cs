using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace lm.Oficina.Domain
{
    public class ConexaoBaseParadox
    {
        public static DataTable RetornarDadosDaBase(string Query, string CaminhoBase)
        {
            string stringConn = @"";

            using (OleDbConnection DbConnection = new OleDbConnection(stringConn))
            {
                try
                {
                    if (ConnectionState.Closed == DbConnection.State)
                        DbConnection.Open();

                    OleDbCommand SQLCommand = new OleDbCommand(Query);
                    OleDbDataAdapter DbAdapter = new OleDbDataAdapter() { SelectCommand = SQLCommand };
                    DataTable Data = new DataTable();

                    DbAdapter.Fill(Data);
                    return Data;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    DbConnection.Close();
                }

            }
        }
    }
}
