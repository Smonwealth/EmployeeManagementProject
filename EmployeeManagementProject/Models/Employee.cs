using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public int BiodataId { get; set; }
    }
}
