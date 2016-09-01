using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Data.SQLite; 
using System.Data; 
using System.Windows.Forms; 

namespace Balanse
{
    public class BalanseConn
    {
        public DataTable SelectQuery(string QueryString)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source= C:\\Balanse"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();


                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.Select(QueryString + ";");
                    conn.Close();


                    return dt;
                }
            }
        }
    }
}

