using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Voting_System.Database.DBWatchers
{
    class DBWatchers
    {
        private static string tablename = "watchers";

        private string number;
        private string municipality;
        private string precinct_no;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        public string Precinct_no
        {
            get { return precinct_no; }
            set { precinct_no = value; }
        }

        public DBWatchers()
        {

        }

        public DBWatchers(string number, string municipality, string precinct_no)
        {
            this.number = number;
            this.municipality = municipality;
            this.precinct_no = precinct_no;
        }

        public void Add( string number, string municipality, string precinct_no)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(@number, @municipality, @precinct_no)";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@municipality", municipality);
                cmd.Parameters.AddWithValue("@precinct_no", precinct_no);

                cmd.ExecuteNonQuery(); //execute the mysql command

                MessageBox.Show("Insert Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        
        public void Delete(string number)
        {
            SQLiteConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE number=@number";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(command, con);
                cmd.Parameters.AddWithValue("@number", number);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBWatchers> GetDataList()
        {
            List<DBWatchers> data = new List<DBWatchers>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBWatchers rawData = new DBWatchers();
                        rawData.Number = reader.GetString(0);
                        rawData.Municipality = reader.GetString(1);
                        rawData.Precinct_no = reader.GetString(2);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public static DBWatchers GetData(string number)
        {
            DBWatchers data = null;

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename + " WHERE number='" + number + "'", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBWatchers();

                    data.Number = reader.GetString(0);
                    data.Municipality = reader.GetString(1);
                    data.Precinct_no = reader.GetString(2);

                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }

    }
}
