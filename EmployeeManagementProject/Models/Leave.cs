using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class Leave
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeOfLeave { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long IsApproved { get; set; }
        public long IsDeclined { get; set; }
        public string ApprovedBy { get; set; }
    }
}
