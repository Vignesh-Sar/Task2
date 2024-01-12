using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LMS.Filter
{
    public class ExceptionLogFilter: ExceptionFilterAttribute,IExceptionFilter
    {
        public override void OnException(ExceptionContext context)
        {
            var exceptionMessage=context.Exception.Message;
            var stackTrace = context.Exception.StackTrace;
            var controlerName = context.RouteData.Values["controller"].ToString();
            var actionName =context.RouteData.Values["action"].ToString();
            var Message = "Date :"+DateTime.Now.ToString("dd-MM-yyyy hh:mm yy")+"Error Message :"+ exceptionMessage+Environment.NewLine+"Stack Trace:"+stackTrace;
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;
            string logFilePath = @"C:\Users\Server\Desktop\LogFile";
            logFilePath = logFilePath+"Log-"+System.DateTime.Today.ToString("dd-mm-yy")+".txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);

            if(!logDirInfo.Exists)
            {
                logDirInfo.Create();

            } 
            if(!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else 
            {
                fileStream=new FileStream(logFilePath,FileMode.Append);

            }
            log = new StreamWriter(fileStream);
            log.WriteLine("Log Created at= "+DateTime.Now.ToString("dd-MM-yyyy hh:mm yy")+"Message : -"+Message);
            log.Close();
        

            base.OnException(context);
        }

        
    }
}