using System.Data;
using System.Data.SqlClient;

public  class Connexion
{
    public static string conString  = "Data Source=DESKTOP-VPJMV81;Initial Catalog=Gestion;Integrated Security=True";
    SqlConnection conn = new SqlConnection(conString);
    public  string Connecter()
    {
        
        conn.Open();
        if (conn.State == System.Data.ConnectionState.Open)
            return "connected";
        else
            return "not connected"; 
    }

    public  bool ExecuteCommand(SqlCommand cmd)
    {
        cmd.Connection = conn;
        if (cmd.ExecuteNonQuery() >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public  SqlDataReader Rdd(string value)
    {
        SqlCommand command = new SqlCommand(value);
        command.Connection = conn;
        SqlDataReader reader = command.ExecuteReader();
        return reader;
    }
}
