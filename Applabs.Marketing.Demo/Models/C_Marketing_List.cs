//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Applabs.Marketing.Demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_Marketing_List
    {
        public int Marketing_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Marketer_Name { get; set; }
        public System.DateTime Marketing_Start_Date { get; set; }
        public string Case_Status { get; set; }
        public System.DateTime Marketing_End_Date { get; set; }
        public string Current_Status { get; set; }


        public List<Employee> emp { get; set; }
        public List<Employee> mar { get; set; }
    }
}