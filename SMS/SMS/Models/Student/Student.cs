using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
    public partial class Dependents
    {
		public int DependentsId { get; set; }

        [JsonIgnore]
		public string DependentsType { get; set; }
		public int StudentId { get; set; }
		public string FirstName { get; set; }
        public String LastName { get; set; }
        public string MiddleName { get; set; }
        public long MobileNumber { get; set; }
        public string Occupation { get; set; }
        public string SalutationId { get; set; }

        public string AadharNumber { get; set; }
		public long AnnualIncome { get; set; }

		public bool BvEmployee { get; set; }

		public string Company { get; set; }

		public string Designation { get; set; }

		public string  Email { get; set; }

        [JsonIgnore]
		public virtual ICollection<Student> Students { get; set; }

	}
    public partial class Student
    {

        [JsonIgnore]
        [IgnoreDataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public StudentUserCred StudentUserCred { get; set; }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string BloodGroup { get; set; }
        public int? NationalityId { get; set; }
        public int? ReligionId { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string AadharNumber { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public int StudentAddressId { get; set; }

        //[JsonIgnore]
        //[IgnoreDataMember]
        //public StudentAddress[] Addresses { get; set; }

        public virtual ICollection<StudentAddress> Addresses { get; set; }

        public long Mobile { get; set; }
        public int AdmissionNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string RollNo { get; set; }
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }
        public string EmisNumber { get; set; }
        public string schoolName { get; set; }
        public int? schoolBrand { get; set; }
        public int? passingOutSchool { get; set; }
        public int? yearofattendence { get; set; }
        public int AcademicPrecentage { get; set; }
        public string ReasonForLeaving { get; set; }
        public byte[] ProfilePic { get; set; }
        public byte[] TransferCertificate { get; set; }
        public byte[] BirthCertificate { get; set; }
        public byte[] Passport { get; set; }
        public byte[] Aadhar { get; set; }
        public byte[] RationCard { get; set; }
        public byte[] StudentVisa {get;set;}

        //[ForeignKey("DependentsId")]
        //public int DependentsId { get; set; }
        public Dependents FatherDetails { get; set; }

        [NotMapped]
        public Dependents MotherDetails { get; set; }

        [NotMapped]
        public Dependents LocalGuardian { get; set; }

        [NotMapped]
        public Dependents LegalGuardian { get; set; }

    }
}
