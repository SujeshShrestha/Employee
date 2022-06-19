namespace Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeMetaData
    {
        [Display(Name = "First Name")]
        public string First_Name;
        [Display(Name = "Middle Name")]
        public string Middle_Name;
        [Display(Name = "Last name")]
        public string Last_Name;

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email_Id;

        [Display(Name = "Mobile Number")]
       
        [StringLength(10)]
        public string Mobile_No;
        [Display(Name = "Address")]
        public string Address;

        public Nullable<bool> Status;
        [Display(Name = "Start Date")]
        public Nullable<System.DateTime> Start_Date;
        [Display(Name = "End Date")]
        public Nullable<System.DateTime> End_Date;
        public Nullable<bool> Emp_Status;
        [Display(Name = "Hours")]
        public Nullable<double> Hours;
        public Nullable<bool> Table_status;
        public Nullable<int> StartDay;
        public MonthEnum.months? StartMonth;
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]

        public Nullable<int> StartYear;
        public Nullable<int> EndDay;
        public MonthEnum.months? EndMonth;
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]

        public Nullable<int> EndYear;
        public bool OnGoing;
        //public DateTime StartDate => new DateTime(StartYear.Value, (int)StartMonth.Value, StartDay.Value);
        //public DateTime EndDate => new DateTime(EndYear.Value, (int)EndMonth.Value, EndDay.Value);

        //public TimeSpan TimeDiffer => OnGoing ? DateTime.Now - StartDate : StartDate - EndDate;


    }

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
    }
}
