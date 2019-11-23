using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace livejourneys // provide scope to organise code into packages
{
    public static class database
    {
        public static OleDbConnection GetConnection() // initalise OleDb connection method for database connection
        {
            string connString;
            connString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = I:\PDCCwrk\livejourneys\db.mdb"; //get database location
             var newCON = new OleDbConnection(connString); // open connection
            return newCON;
        }

        public static bool pullUsernameandPass(string username, string password) // method to get username and password
        {

            OleDbConnection myConnection = GetConnection(); // get database path and connect to it
            string executeQueryStr = "SELECT * FROM userinfo_ WHERE UserName = '" + username + "' AND Password = '" + password + "'"; // SQL statement to get username and password fromt the database
            OleDbCommand dbCommand = new OleDbCommand(executeQueryStr, myConnection); // convert string into a OleDbCommand
            dbCommand.Connection = myConnection; // initalise connection


            try
            {
                myConnection.Open(); // open connection in database
                OleDbDataReader reader = dbCommand.ExecuteReader(); //  // 

                if (reader.HasRows)
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Write Query To Database", ex); // run if there is exception, output in console
            }
            finally
            {

                myConnection.Close();
            }


            return false;
        }
        public static string getQuestions(string ageGroup, string id) //gets questions from database table
        {


            OleDbConnection myConnection = GetConnection(); // get connection
            string query = "SELECT * FROM " + ageGroup + " WHERE QID = '" + id + "'"; // SQL statement to get question from database
            OleDbCommand command = new OleDbCommand(query, myConnection); // convert string SQL STATEMENT into a OleDbCommand 
            command.Connection = myConnection;

            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database

                if (reader.Read())
                {
                    return reader.GetString(1).ToString(); // return second column


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }

            myConnection.Close();
            return "ERRROR!!!!!";


        }
        public static string addtrainline(string trainline)
        { 
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "insert into trainlines_ ([trainlines]) values (?)"; // command to instert trainlines
                dbCommand.Parameters.AddWithValue("@trainlines", trainline); //adds variable "user" value to the SQL statement
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                return "ERROR";
            }

            return "Trainline successfully added.";

        }
        public static OleDbDataReader populatelistview()
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT * FROM trainlines_"; 
            OleDbCommand command = new OleDbCommand(query, myConnection); 
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database
                return reader;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }

        public static string deletetrainline(int  id)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "Delete FROM trainlines_ WHERE ID = " +id;
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR" + ex;
            }

            return "Trainline successfully deleted.";

        }

        public static void edittrainlines(string line, int id)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "UPDATE trainlines_ SET trainlines = '"+ line +"' WHERE ID = " + id;
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception) { }
        }
        public static string addstation(string station)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "insert into trainstations_ ([stations]) values (?)";
                dbCommand.Parameters.AddWithValue("@trainlines", station); 
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception)
            {
                return "ERROR";
            }

            return "Station successfully added.";

        }
        public static OleDbDataReader populatestationlist()
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT * FROM trainstations_";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database
                return reader;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }
        public static string deletestation(int id)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "Delete FROM trainstations_ WHERE ID = " + id;
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR" + ex;
            }

            return "Station successfully deleted.";
        }
        public static void editstation(string station, int id)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "UPDATE trainstations_ SET stations = '" + station + "' WHERE ID = " + id;
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception) { }
        }

        public static void link(int tid, int sid, int disvalue)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "insert into linklinestostations_ ([trainline_FK],[station_FK],[distance]) values (?,?,?)";
                dbCommand.Parameters.AddWithValue("@trainlines", tid);
                dbCommand.Parameters.AddWithValue("@stations", sid);
                dbCommand.Parameters.AddWithValue("@distance", disvalue);
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception) { }
        }
        public static int gettrainid(string trainline)
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT ID FROM trainlines_ WHERE trainlines = '" + trainline+"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database

                reader.Read();

                return reader.GetInt32(0);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return 0;
        }
        public static int getstationid(string station)
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT ID FROM trainstations_ WHERE stations = '" + station + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database

                reader.Read();

                return reader.GetInt32(0);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return 0;
        }
        public static OleDbDataReader showlinkedlineandstation()
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT linklinestostations_.ID, trainlines_.trainlines, trainstations_.stations, linklinestostations_.distance FROM trainstations_ INNER JOIN (trainlines_ INNER JOIN linklinestostations_ ON trainlines_.ID = linklinestostations_.trainline_FK) ON trainstations_.ID = linklinestostations_.station_FK";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database
                return reader;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }
        public static string deletelinks(int linkid)
        {
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();

                dbCommand.CommandText = "Delete FROM linklinestostations_ WHERE ID = " + linkid;
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR" + ex;
            }

            return "Station successfully deleted.";
        }

        public static OleDbDataReader displaylinkedlinestatndist(int tid)
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT linklinestostations_.ID, trainlines_.trainlines, trainstations_.stations, linklinestostations_.distance FROM trainstations_ INNER JOIN (trainlines_ INNER JOIN linklinestostations_ ON trainlines_.ID = linklinestostations_.trainline_FK) ON trainstations_.ID = linklinestostations_.station_FK WHERE trainline_FK =" + tid;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database
                return reader;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }
        public static int calculatedistance(int trid,  int stid, int desid)
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT Sum(linklinestostations_.distance) AS distance FROM linklinestostations_ WHERE (((linklinestostations_.station_FK) Between "+stid+" AND "+desid+") AND ((linklinestostations_.trainline_FK)="+trid+"))";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database

                reader.Read();
                return Int32.Parse(reader["distance"].ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return 0;
        }
        public static OleDbDataReader gettlinesofthatstation(int stid)
        {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT trainlines_.trainlines FROM trainstations_ INNER JOIN (trainlines_ INNER JOIN linklinestostations_ ON trainlines_.ID = linklinestostations_.trainline_FK) ON trainstations_.ID = linklinestostations_.station_FK WHERE (((linklinestostations_.station_FK)="+ stid+"))";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database
                return reader;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }
        

    }
}
