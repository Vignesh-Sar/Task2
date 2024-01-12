using System;
namespace LMS.Models{
    public class LeaveEligibility{
   
        public int privileged_Leave{get;set;}=4;
         public int Compansatory_Leave{get;set;}=2;
         public int Maternity_Leave{get;set;}=0;
         public int Paternity_Leave{get;set;}=1;
         public int LOP_Leave{get;set;}=0;
         public int Carry_Forward{get;set;}=3;
         public int Encashed_Days{get;set;}=0;
         public int Marriage_Leave{get;set;}=1;
         public int MTP_Leave{get;set;}=0;

         public string? DateTime{get;set;}="JAN 2023 - DEC 2023";         
         

         
         
         

    }
}