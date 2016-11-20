using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace Voting_System.Database
{
    class DBPrefix
    {
        private string tablename = "prefixes";
        
        private string smart;
        private string globe;
        private string sun;

        public string Smart
        {
            get { return smart; }
            set { smart = value; }
        }

        public string Globe
        {
            get { return globe; }
            set { globe = value; }
        }

        public string Sun
        {
            get { return sun; }
            set { sun = value; }
        }

        public void Add(string smart, string globe, string sun)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(NULL,@smart,@globe,@sun)";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@smart", smart);
                cmd.Parameters.AddWithValue("@globe", globe);
                cmd.Parameters.AddWithValue("@sun", sun);

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

        public void Update(string column, string data)
        {
            string cmdText = "UPDATE " + tablename + " SET " + column + " = @data WHERE id = 1";
            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@data", data);
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

        public void Delete(string id)
        {
            SQLiteConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(command, con);
                cmd.Parameters.AddWithValue("@id", id);

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

        public List<DBPrefix> GetData()
        {
            List<DBPrefix> data = new List<DBPrefix>();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrefix rawData = new DBPrefix();
                        rawData.Smart = reader.GetString(1);
                        rawData.Globe = reader.GetString(2);
                        rawData.Sun = reader.GetString(3);

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

        public DBPrefix SearchPrefix()
        {
            DBPrefix data = new DBPrefix();

            SQLiteConnection con = DBConnection.ConnectDatabase();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data.Smart = reader.GetString(1);
                        data.Globe = reader.GetString(2);
                        data.Sun = reader.GetString(3);
                    }
                }
                else
                    data = null;

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
