using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


public class DatabaseHelper
{
    private string _connectionString;

    // Constructor to initialize the connection string
    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Method to open and return a SQL connection
    public SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection;
    }

    // Method to execute a query (e.g., SELECT)
    public DataTable ExecuteQuery(string query)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    // Method to execute non-query commands (e.g., INSERT, UPDATE, DELETE)
    public int ExecuteNonQuery(string query)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return command.ExecuteNonQuery();
            }
        }
    }
}
