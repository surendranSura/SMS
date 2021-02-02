using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
    public partial class Staff
    {
        public virtual Person Person { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public int StaffId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public int PersonId { get; set; }
        public string StaffType { get; set; }
        public string Esinumber { get; set; }
        public string Epfnumber { get; set; }
        public string Uannumber { get; set; }
        public int ReportingTo { get; set; }
        public DateTime JoiningDate { get; set; }
        public string OfficialEmailId { get; set; }
        public string TeacherId { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankIfscCode { get; set; }
        public string PanNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public string SpouseOccupation { get; set; }
        public string FatherMobileNumber { get; set; }
        public string MotherMobileNumber { get; set; }
        public string SpouseMobileNumber { get; set; }

        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Department Department { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Designation Designation { get; set; }

		public StaffExperience[] Experience { get; set; }
    }
}
