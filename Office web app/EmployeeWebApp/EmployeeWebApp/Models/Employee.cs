using System;
using System.Collections.Generic;

namespace EmployeeWebApp.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public int? EmployeeAge { get; set; }
        public string EmployeePhonenumber { get; set; }
    }
}
