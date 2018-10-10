using Dream_Society_Project.EnvironmentConfigurartion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace DreamSociety.BusinessLayer
{
    /// <summary>
    /// Useful utilities for Microsoft Access Database files.
    /// </summary>
    public static class AccessDbLoader
    {
        /// <summary>
        /// Loads a Microsoft Access Database file into a DataSet object.
        /// The file can be the in the newer ACCDB format or MDB legacy format.
        /// </summary>
        /// <param name="fileName">The file name to load.</param>
        /// <returns>A DataSet object with the Tables object populated with the contents of the specified Microsoft Access Database.</returns>
        public static DataSet LoadFromFile()
        {
            DataSet result = new DataSet();

            string connString = EnvironmentConfig.ConnectionString;

            // Opening the Access connection
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Getting all user tables present in the Access file (Starts with tbl_ name)
                    DataTable dt = conn.GetSchema("Tables");
                    List<string> tablesName = dt.AsEnumerable().Select(dr => dr.Field<string>("TABLE_NAME")).Where(dr => dr.StartsWith("tbl_")).ToList();

                    // Getting the data for every user tables
                    foreach (string tableName in tablesName)
                    {
                        using (OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}]", tableName), conn))
                        {
                            using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                            {
                                // Saving all tables in our result DataSet.
                                DataTable buf = new DataTable("[" + tableName + "]");
                                adapter.Fill(buf);
                                result.Tables.Add(buf);
                            } // adapter
                        } // cmd
                    } // tableName
                } // conn
                catch (Exception ex) 
                {
                    MessageBox.Show("Issue occured at {0}",ex.Message); 
                }
            }



            // Return the filled DataSet
            return result;
        }
    }
}