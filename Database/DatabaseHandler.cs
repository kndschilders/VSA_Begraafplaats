using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DatabaseHandler
    {
        private static SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:/Users/gebruiker-pc/Documents/GitHub/VSA_Begraafplaats/Database/src/begraafplaats.db;Version=3");
        private static bool connectionIsOpen;

        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                connectionIsOpen = true;
            }
            catch (SQLiteException)
            {
                return false;
            }

            return true;
        }

        private static void CloseConnection()
        {
            try
            {
                connection.Close();
                connectionIsOpen = false;
            }
            catch (SQLiteException)
            {
                throw;
            }
        }

        public static DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters, bool closeConnection = true)
        {
            if (query == null)
            {
                throw new ArgumentNullException("Query can not be null.");
            }

            if (query.Trim().Length == 0)
            {
                throw new ArgumentException("Query can not be an empty string.");
            }

            if (!connectionIsOpen)
            {
                OpenConnection();
            }

            DataTable datatable = new DataTable();

            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = query;

                if (parameters != null)
                {
                    foreach (KeyValuePair<String, Object> parameter in parameters)
                    {
                        SQLiteParameter sqLiteParameter = new SQLiteParameter(parameter.Key, parameter.Value);
                        command.Parameters.Add(sqLiteParameter);
                    }
                }

                SQLiteDataReader reader = command.ExecuteReader();
                datatable.Load(reader);
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Probleem met de database: " + ex.Message);
            }
            finally
            {
                if (closeConnection)
                {
                    CloseConnection();
                }
            }

            return datatable;
        }

        public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters, bool closeConnection = true)
        {
            if (query == null)
            {
                throw new ArgumentNullException("Query can not be null.");
            }

            if (query.Trim().Length == 0)
            {
                throw new ArgumentException("Query can not be an empty string.");
            }

            if (!connectionIsOpen)
            {
                OpenConnection();
            }

            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = query;

                if (parameters != null)
                {
                    foreach (KeyValuePair<String, Object> parameter in parameters)
                    {
                        SQLiteParameter sqLiteParameter = new SQLiteParameter(parameter.Key, parameter.Value);
                        command.Parameters.Add(sqLiteParameter);
                    }
                }

                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Probleem met de database: " + ex.Message);
            }
            finally
            {
                if (closeConnection)
                {
                    CloseConnection();
                }
            }
        }
    }
}
