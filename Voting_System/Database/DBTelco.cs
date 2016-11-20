using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace Voting_System.Database
{
    class DBTelco
    {
        private string tablename = "telco";

        private string telconame;


        public string TelcoName
        {
            get { return telconame; }
            set { telconame = value; }
        }

        public void Add(string telconame)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(@telconame)";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(string previousname, string newname)
        {
            string cmdText = "UPDATE " + tablename + " SET telconame = @newname WHERE telconame = @previousname";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@previousname", previousname);
                cmd.Parameters.AddWithValue("@newname", newname);
                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(string telconame)
        {
            SQLiteConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE telconame=@telconame";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(command, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public List<DBTelco> GetData()
        {
            List<DBTelco> data = new List<DBTelco>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBTelco rawData = new DBTelco();
                        rawData.TelcoName = reader.GetString(0);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }
    }
}
