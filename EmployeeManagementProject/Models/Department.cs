using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Acronym { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
