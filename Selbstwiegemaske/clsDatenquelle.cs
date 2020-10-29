using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Selbstwiegemaske
{
    class clsDatenquelle
    {
        #region globale Eigenschaften
        public SqlDataAdapter Adapter { get; set; }
        public DataTable dataTable { get; set; }
        #endregion
    }
}
