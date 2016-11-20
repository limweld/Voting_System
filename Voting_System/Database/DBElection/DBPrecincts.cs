using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Voting_System.Database.DBElection
{
    class DBPrecincts
    {
        private static string tablename = "precincts";

        private int id;
        private string municipality;
        private string precinct;
        private int votes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        public string Precinct
        {
            get { return precinct; }
            set { precinct = value; }
        }

        public DBPrecincts()
        {

        }

        public DBPrecincts(int id, string municipality, string precinct, int votes)
        {
            this.id = id;
            this.municipality = municipality;
            this.precinct = precinct;
            this.votes = votes;
        }

        public DBPrecincts(string municipality)
        {
            this.municipality = municipality;
        }

        public DBPrecincts(string municipality,string precinct)
        {
            this.municipality = municipality;
            this.Precinct = precinct;
        }

        public static List<DBPrecincts> GetDataListMunicipality()
        {
            List<DBPrecincts> data = new List<DBPrecincts>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT municipality FROM " + tablename + " GROUP BY municipality", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrecincts rawData = new DBPrecincts();
                        rawData.Municipality = reader.GetString(0);
                    
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

        public static List<DBPrecincts> GetDataListPrecinct_no(string municipality) 
        {
            List<DBPrecincts> data = new List<DBPrecincts>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT precinct FROM " + tablename + " WHERE municipality='" + municipality + "'", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrecincts rawData = new DBPrecincts();
                        rawData.Precinct = reader.GetString(0);

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
    }
}
