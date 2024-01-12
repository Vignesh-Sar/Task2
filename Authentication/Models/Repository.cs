using System;
using System.Data.SqlClient;

namespace Authentication.Models
{
    public class Repository 
    {
        
       public static string Role(Login login)
       {
            using(SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1MRHJV7; Initial Catalog=MVCFile; Integrated Security=true"))
            {
            connection.Open();
            SqlCommand sqlcommand = new SqlCommand($"select Role from Signups where Name=@username",connection);
            sqlcommand.Parameters.Add("@username",sqlDbType:System.Data.SqlDbType.VarChar).Value = login.Name;
            string? role = Convert.ToString(sqlcommand.ExecuteScalar());
            return role;  
            }
        }
    }
}