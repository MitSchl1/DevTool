using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class AddDataDB
    {
        public void addData()
        {
            string constr;

            // for the connection to
            // sql server database
            SqlConnection conn;

            // Data Source is the name of the
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;

            // data adapter object is use to
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";

            // use the defined sql statement
            // against our database
            sql = "insert into demo values(3, 'Python')";

            // use to execute the sql command so we
            // are passing query and connection object
            cmd = new SqlCommand(sql, conn);

            // associate the insert SQL
            // command to adapter object
            adap.InsertCommand = new SqlCommand(sql, conn);

            // use to execute the DML statement against
            // our database
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects
            cmd.Dispose();
            conn.Close();
        }

    }
}
