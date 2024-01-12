using System;
using System.Data.SqlClient;

namespace dataannotations.Models
{
    public class Repository : IRepository
    {
        public List<Data> UserList;
          public Repository(){
            UserList = new List<Data>();
        }
        public void AddData(Data data)
        {
            UserList.Add(data);
        }

        public IEnumerable<Data> GetData()
        {
            return UserList;
        }
       public static bool validate(Login login)
       {
        SqlConnection connection = new SqlConnection("Data Source=STBK; Initial Catalog=MVCApplication; Integrated Security=true");
            connection.Open();
            SqlCommand sqlcommand = new SqlCommand($"select count(*) from Signups where Name=@username and Password=@password",connection);
            sqlcommand.Parameters.Add("@username",sqlDbType:System.Data.SqlDbType.VarChar).Value = login.Name;
            sqlcommand.Parameters.Add("@password",sqlDbType:System.Data.SqlDbType.VarChar).Value = login.Password;
            if(Convert.ToInt32(sqlcommand.ExecuteScalar())==1){
                    return true;
                }
            return false;
       }
       public static string Role(Login login)
       {
            using(SqlConnection connection = new SqlConnection("Data Source=STBK; Initial Catalog=MVCApplication; Integrated Security=true"))
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