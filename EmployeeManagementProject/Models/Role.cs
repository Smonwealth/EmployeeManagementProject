using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Rank { get; set; }
        public string RoleName { get; set; }
    }
}
