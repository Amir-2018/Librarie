using Models2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Text;

namespace Controllers2
{
    public class AuthenticateAdmin
    {
        public bool Auth_client(string email, string password)
        {
            // Connection string to the SQL Server database
            string connectionString = "Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True";

            // SQL query to retrieve the client with the provided email and address
            string query = "SELECT COUNT(*) FROM Admin WHERE email=@email AND password=@password";

            // Create a new SqlConnection object with the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand object with the query and connection object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the email and address parameters to the SqlCommand object
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    // Open the database connection
                    connection.Open();

                    // Execute the query and retrieve the number of matching clients
                    int count = (int)command.ExecuteScalar();

                    // Close the database connection
                    connection.Close();

                    // If the count is greater than 0, the client exists and is authenticated
                    return count > 0;
                }
            }
        }

    }
}
