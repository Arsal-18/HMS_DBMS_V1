//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS_DBMS_V1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<int> YearsOfExperience { get; set; }
        public string EmployeeType { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}