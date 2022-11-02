using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementProject.Models
{
    public partial class BioData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public DateTime Dob { get; set; }
        public string Nationality { get; set; }
        public string StateOfOrigin { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Passport { get; set; }
        public string BloodGroup { get; set; }
        public string Genotype { get; set; }
        public string LocalGovtOfOrigin { get; set; }
        public string RegistrationStatus { get; set; }
    }
}
