using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DB2JSON
{
    public class AccessHelper
    {
        static OleDbConnection olecon = null;
        static AccessHelper()
        {
            string constr = string.Format("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {0}", Path.Combine(Application.StartupPath, "LEDInfo.mdb"));
            olecon = new OleDbConnection(constr);
        }

        public static DataTable GetDataTable(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, olecon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
    }
}
