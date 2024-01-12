using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using LMS.Controllers;
using System;



#nullable disable

namespace LMS.Models
{
    public class Repositorydetails{
    
     public static List <RequestLeaveDetails> names = new List<RequestLeaveDetails> ();
        static SqlConnection connection =  new SqlConnection("Data source = DESKTOP-RPT3F1B;Initial Catalog = LMS;integrated security=SSPI");
        public static IEnumerable<RequestLeaveDetails> AllList
        {
         get{
                return names;
            }
        }
        public static string RemoveDetails(CancelRequest RLD)
        {   
             
             

            connection.Open();
            SqlCommand command4=new SqlCommand("select count(*) from Table_4 where Userid='"+RLD.ID+"'AND  UserName='"+RLD.Name+"' AND  Start_Date ='"+RLD.SDate+"' AND End_Date='"+RLD.EDate+"' ;",connection );
            int count = Convert.ToInt32(command4.ExecuteScalar());
            connection.Close();
            if(count>0)
            {
                try{

              connection.Open();
              SqlCommand command1=new SqlCommand("delete from Table_4 where Userid='"+RLD.ID+"' and UserName='"+RLD.Name+"' and Start_Date ='"+RLD.SDate+"' and End_Date='"+RLD.EDate+"' ;",connection );
              command1.ExecuteNonQuery();
              return "ok";
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("SqlException"+ex);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                finally{
              connection.Close();
              }
              

           
            }
             return "Notok";
        }
      
            
                
    }

}    

    


