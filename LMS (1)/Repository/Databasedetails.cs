
using System.Data.SqlClient;
using System.Data;
using LMS.Models;
using LMS.IRepository;
namespace LMS.Repository{
    public class Databasedetails:IDatabasedetails
    {
     int check,count,value,total;
       List<RequestLeaveDetails> ec =new List<RequestLeaveDetails>();
       System.Data.DataSet ds = new System.Data.DataSet();
    //  int count;
        private readonly string  ? ConnectionString;
        public Databasedetails(IConfiguration configuration){
            ConnectionString=configuration["ConnectionStrings:DefaultConnection"];
        }

        public string ? SearchDetails(string? username,string? password,string? userid)
        {
                Console.WriteLine(username+""+password+""+userid);
                using(SqlConnection sqlConnection=new SqlConnection(ConnectionString)){
                    using (SqlCommand sqlCommand = new SqlCommand("LoginProcedure",sqlConnection)){
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Action", "SELECT");
                        sqlCommand.Parameters.AddWithValue("@SpecificCondition", "COUNT");
                        sqlCommand.Parameters.AddWithValue("@UserName",username);
                        sqlCommand.Parameters.AddWithValue("@PassWord",password);  
                         sqlCommand.Parameters.AddWithValue("@Userid",userid);
                        
                        sqlConnection.Open();
                        check=Convert.ToInt32(sqlCommand.ExecuteScalar());
                        // Console.WriteLine(sqlCommand.ExecuteScalar());
                    }
            }
            Console.WriteLine(check);
            if(check>0)
                    {

                    return "Ok";
                   }
                else{
                return "Notok";
                }
        }
        public string ? Forgetpassword(string? username,string? password)
        {
            Console.WriteLine(username+" "+password);
            using(SqlConnection sqlConnection=new SqlConnection(ConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("LoginProcedure",sqlConnection))
                {
                   sqlCommand.CommandType = CommandType.StoredProcedure;
                   sqlCommand.Parameters.AddWithValue("@Action","SELECT");
                   sqlCommand.Parameters.AddWithValue("@SpecificCondition","UserName");
                   sqlCommand.Parameters.AddWithValue("@UserName",username);
                   
                   sqlConnection.Open();
                   count=Convert.ToInt32(sqlCommand.ExecuteScalar());
                   
                //    Console.WriteLine(count);

                }
            }
           
            if(count>0)
            {
                
                using(SqlConnection sqlConnection=new SqlConnection(ConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("LoginProcedure",sqlConnection))
                {
                   Console.WriteLine(password);
                   sqlCommand.CommandType = CommandType.StoredProcedure;
                   sqlCommand.Parameters.AddWithValue("@Action","UPDATE");
                   sqlCommand.Parameters.AddWithValue("@UserName",username);
                   sqlCommand.Parameters.AddWithValue("@PassWord",password);
                 
                   sqlConnection.Open();
                   Convert.ToInt32(sqlCommand.ExecuteNonQuery());
                  
                   
                   

                }
            }
              return "ok";
            }
            else
            {
                return "Notok";
            }
        }
        public string ? LeaveRequest(string? userid,string? username,string? mail, string? des,string? startdate,string? enddate,string? leavetype,string ? emprequest)
        {
         using(SqlConnection sqlConnection=new SqlConnection(ConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("CancelvalueProcedure",sqlConnection))
                {
                   sqlCommand.CommandType = CommandType.StoredProcedure;
                   sqlCommand.Parameters.AddWithValue("@Action","INSERT");
                   sqlCommand.Parameters.AddWithValue("@UserName",username);
                   sqlCommand.Parameters.AddWithValue("@Userid",userid);
                   sqlCommand.Parameters.AddWithValue("@Mail",mail);
                   sqlCommand.Parameters.AddWithValue("@Des",des);
                   sqlCommand.Parameters.AddWithValue("@Start_Date",startdate);
                   sqlCommand.Parameters.AddWithValue("@End_Date",enddate);
                   sqlCommand.Parameters.AddWithValue("@Leave_Type",leavetype);
                   sqlCommand.Parameters.AddWithValue("@EmpRequest",emprequest);
                   sqlConnection.Open();
                   value=Convert.ToInt32(sqlCommand.ExecuteScalar());
                   
                   

                }
            } 
            if(value>0)
            {
                return "ok";
            }  
            else{
                return "Notok";
            }

        }
        // public List<RequestLeaveDetails> showresults (string ? id)
        // {
          
       
        // }
        
    }
}