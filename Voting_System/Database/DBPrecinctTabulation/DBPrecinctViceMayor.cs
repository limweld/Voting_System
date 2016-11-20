using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Voting_System.Database.DBPrecinctTabulation
{
    class DBPrecinctViceMayor
    {
        private static string tablename = "vicemayor_tabulation";

        private int id;
        private string municipality;
        private string precinct;
        private int votes;
        private int candidate_id;

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

        public int Votes
        {
            get { return votes; }
            set { votes = value; }
        }

        public int Candidate_id
        {
            get { return candidate_id; }
            set { candidate_id = value; }
        }

        public DBPrecinctViceMayor()
        {

        }

        public DBPrecinctViceMayor(int candidate_id, int votes)
        {
            this.candidate_id = candidate_id;
            this.votes = votes;
        }

        public void Add(string municipality, string precinct, int votes, int candidate_id)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(NULL, @municipality, @precinct, @votes, @candidate_id)";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@municipality", municipality);
                cmd.Parameters.AddWithValue("@precinct", precinct);
                cmd.Parameters.AddWithValue("@votes", votes);
                cmd.Parameters.AddWithValue("@candidate_id", candidate_id);

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

        public void Update(string municipality, string precinct, int votes, int candidate_id)
        {
            //String sql = "update tblproductcategory set SCode ='" + value1 + "' ,Description='" + value2 + "' ,Notes ='" + value3 + "' where Scode = '" + scode + "' ";
            string cmdText = "UPDATE " + tablename + " SET votes=@votes WHERE municipality=@municipality AND precinct=@precinct AND candidate_id=@candidate_id";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@votes", votes);
                cmd.Parameters.AddWithValue("@municipality", municipality);
                cmd.Parameters.AddWithValue("@precinct", precinct);
                cmd.Parameters.AddWithValue("@candidate_id", candidate_id);

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

        public void ClearLogs()
        {
            SQLiteConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(command, con);

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

        public static DBPrecinctViceMayor GetDataByPrecinct(string precinct, string municipality, int candidate_id)
        {
            DBPrecinctViceMayor data = null;

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename + " WHERE precinct='" + precinct + "' AND municipality='" + municipality + "' AND candidate_id=" + candidate_id, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPrecinctViceMayor();
                    data.Id = reader.GetInt32(0);
                    data.Municipality = reader.GetString(1);
                    data.Precinct = reader.GetString(2);
                    data.Votes = reader.GetInt32(3);
                    data.Candidate_id = reader.GetInt32(4);
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

        public static List<DBPrecinctViceMayor> SumationDataTabulation(string municipality)
        {
            List<DBPrecinctViceMayor> data = new List<DBPrecinctViceMayor>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT candidate_id,SUM(votes) FROM " + tablename + " WHERE municipality='" + municipality + "' GROUP by candidate_id", con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrecinctViceMayor rawData = new DBPrecinctViceMayor();
                        rawData.Candidate_id = reader.GetInt32(0);
                        rawData.Votes = reader.GetInt32(1);

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
