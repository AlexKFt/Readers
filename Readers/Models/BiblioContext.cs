using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readers.Models
{
    sealed class BiblioContext
    {
        private OracleConnection db;
        private string conString;

        public BiblioContext(string source, string readerId, string pwd)
        {
            conString = "Data Source=" + source + ";Password=" + pwd.ToUpper() + ";User ID=" + readerId;
        }

        public void connect()
        {
            db = new OracleConnection();
            db.ConnectionString =  "Data Source=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST = 10.17.129.190)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = lib.ntbd)));User Id=id_logic;Password=IDL;"; ;
            db.Open();
        }

        public void disconnect()
        {
            db.Close();
        }

        public Dictionary<string, object> callProcedure(string fond, string name, List<OracleParameter> paramList)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = db;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = fond + "." + name;

            foreach (var p in paramList)
                command.Parameters.Add(p);

            if (db.State != ConnectionState.Open)
            {
                connect();
            }
            command.ExecuteNonQuery();

            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (var p in paramList)
            {
                if (p.Direction == ParameterDirection.Output || p.Direction == ParameterDirection.ReturnValue)
                {
                    result.Add(p.ParameterName, p.Value);
                }
            }
            return result;
        }

    }
}
