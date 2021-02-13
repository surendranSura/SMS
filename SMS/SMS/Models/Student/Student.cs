using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
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
        public StudentAddress[] Addresses { get; set; }

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
        public string FathersSalutation { get; set; }
        public string FathersFirstName { get; set; }
        public string FathersMiddleName { get; set; }
        public string FathersLastName { get; set; }
        public string FathersMobileNumber { get; set; }
        public string FathersOccupation { get; set; }
        public string FathersEmail { get; set; }
        public string FathersAadharNumber { get; set; }
        public string FathersCompany { get; set; }
        public string FathersDesignation { get; set; }
        public long FathersAnnualIncome { get; set; }
        public string MothersSalutation { get; set; }
        public string MothersFirstName { get; set; }
        public string MothersMiddleName { get; set; }
        public string MothersLastName { get; set; }
        public string MothersMobileNumber { get; set; }
        public string MotherEmail { get; set; }
        public string MothersOccupation { get; set; }
        public string MothersCompany { get; set; }
        public string MothersDesignation { get; set; }
        public long MothersAnnualIncome { get; set; }
        public string MothersAadharNumber { get; set; }
        public string LocalGaurdianSalutation { get; set; }
        public string LocalGaurdianFirstName { get; set; }
        public string LocalGaurdianMiddleName { get; set; }
        public string LocalGaurdianLastName { get; set; }
        public string LocalGaurdianMobileNumber { get; set; }
        public string LocalGaurdianOccupation { get; set; }
        public string LocalGaurdianCompany { get; set; }
        public string LocalGaurdianSalary { get; set; }
        public string LocalGaurdianDesignation { get; set; }
        public long LocalGaurdianAnnualIncome { get; set; }
        public string LocalGaurdianAadharNumber { get; set; }
        public string LegalGaurdianSalutation { get; set; }
        public string LegalGaurdianFirstName { get; set; }
        public string LegalGaurdianMiddleName { get; set; }
        public string LegalGaurdianLastName { get; set; }
        public string LegalGaurdianMobileNumber { get; set; }
        public string LegalGaurdianOccupation { get; set; }
        public string LegalGaurdianCompany { get; set; }
        public string LegalGaurdianDesignation { get; set; }
        public long LegalGaurdianAnnualIncome { get; set; }
        public string LegalGaurdianAadharNumber { get; set; }
        public string LegalGaurdianSalary { get; set; }

        public byte[] ProfilePic { get; set; }
        public byte[] TransferCertificate { get; set; }
        public byte[] BirthCertificate { get; set; }
        public byte[] Passport { get; set; }
        public byte[] Aadhar { get; set; }
        public byte[] RationCard { get; set; }
        public byte[] StudentVisa {get;set;}
}
}
