using System;
using System.Collections.Generic;

#nullable disable

namespace SMS.Models
{
    public partial class staff
    {
        public int EmployeeId { get; set; }
        public string StaffType { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string EsiNumber { get; set; }
        public string EpfNumber { get; set; }
        public string UanNumber { get; set; }
        public int? ReportingTo { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string OfficialEMailId { get; set; }
        public string TeacherId { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankAcNumber { get; set; }
        public string BankIfscCode { get; set; }
        public string PanNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string FaterOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public string SpouceOccupation { get; set; }
        public string FatherMobileNumber { get; set; }
        public string MotherMobileNumber { get; set; }
        public string SpoucseMobileNumber { get; set; }
    }
}
