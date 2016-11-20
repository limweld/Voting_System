using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;



namespace Voting_System.Database
{
    class DBConnection
    {
        public static SQLiteConnection ConnectDatabase()
        {
            SQLiteConnection con = null;
            String connectionStr = "Data Source=MyDatabase.sqlite;Version=3;";

            try
            {
                con = new SQLiteConnection(connectionStr);
                con.Open(); //open the connection
                //MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection : " + ex.Message);
            }

            return con;
        }


    }
}
