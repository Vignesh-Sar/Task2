using System.Data;
using LMS.Models;

namespace LMS.IRepository{
    public interface IDatabasedetails
    {
       
        public string ? SearchDetails(string? username,string? password,string? userid);
        public string ? Forgetpassword (string? username,string? password);
        public string ? LeaveRequest(string? userid,string? username,string? mail, string? des,string? startdate,string? enddate,string? leavetype,string emprequest);
        // public List<RequestLeaveDetails> showresults(string ? id);
    }
}