using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fiap.OracleConexao.Config
{
    public class AppConfig
    {
        public static string OracleConnectionString { get; } = "User ID=rm551104;Password=260105;DataSource = (DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";
    }
}
