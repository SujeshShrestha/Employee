namespace Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeMetaData
    {
        public string First_Name;
        public string Middle_Name;
        public string Last_Name;
        public string Email_Id;
        public string Mobile_No;
        public string Address;
        public Nullable<bool> Status;
        public Nullable<System.DateTime> Start_Date;
        public Nullable<System.DateTime> End_Date;
        public Nullable<bool> Emp_Status;
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
