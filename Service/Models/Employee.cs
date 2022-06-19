//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Id { get; set; }
        public string Mobile_No { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<bool> Emp_Status { get; set; }
        public Nullable<double> Hours { get; set; }
        public Nullable<bool> Table_status { get; set; }
        public Nullable<int> StartDay { get; set; }
        public Nullable<int> StartMonth { get; set; }
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]

        public Nullable<int> StartYear { get; set; }
        public Nullable<int> EndDay { get; set; }
        public Nullable<int> EndMonth { get; set; }
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]

        public Nullable<int> EndYear { get; set; }
        public bool OnGoing { get; set; }

        

    }
}