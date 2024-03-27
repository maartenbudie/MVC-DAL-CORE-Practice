using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using Core;

namespace DAL
{
    public class Data : IData
    {
        public int id {  get; set; }
        public List<int> GetIDs()
        {
            List<int> data = new List<int>();

            try
            {
                string connectionString = @"Data Source=localhost; Initial Catalog=TestDB; Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ID FROM Table_1;";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ID"]);
                        data.Add(id);
                    }
                    reader.Close();
                }
            }
            catch
            {

            }
            return data;
        }
    }
}
