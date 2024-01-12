namespace dependancy_injection
{
    public class  ScopeMessage:IScopeMessage
    {
        public string ? Companyname {get;set;}
        public string? Place {get ; set;}
        public string ?Contactnumber { get;set;}
        public ScopeMessage()
        {
            Companyname = "Zoho";
            Place = "Chennai";
            Contactnumber = "9361318827";
        }
    }
}