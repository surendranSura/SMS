using System;
using System.Collections.Generic;

#nullable disable

namespace SMS.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public int PersonId { get; set; }
        public string EmisNumber { get; set; }
        public string RollNo { get; set; }
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string FathersSalutation { get; set; }
        public string FathersFirstName { get; set; }
        public string FathersMiddleName { get; set; }
        public string FathersLastName { get; set; }
        public string FathersMobileNumber { get; set; }
        public string FathersOccupation { get; set; }
        public string FathersOrganization { get; set; }
        public string FathersDesignation { get; set; }
        public decimal FathersAnnualIncome { get; set; }
        public string FathersAadharNumber { get; set; }
        public string MothersSalutation { get; set; }
        public string MothersFirstName { get; set; }
        public string MothersMiddleName { get; set; }
        public string MothersLastName { get; set; }
        public string MothersMobileNumber { get; set; }
        public string MothersOccupation { get; set; }
        public string MothersOrganization { get; set; }
        public string MothersDesignation { get; set; }
        public decimal MothersAnnualIncome { get; set; }
        public string MothersAadharNumber { get; set; }
        public string LocalGaurdianSalutation { get; set; }
        public string LocalGaurdianFirstName { get; set; }
        public string LocalGaurdianMiddleName { get; set; }
        public string LocalGaurdianLastName { get; set; }
        public string LocalGaurdianMobileNumber { get; set; }
        public string LocalGaurdianOccupation { get; set; }
        public string LocalGaurdianOrganization { get; set; }
        public string LocalGaurdianDesignation { get; set; }
        public decimal LocalGaurdianAnnualIncome { get; set; }
        public string LocalGaurdianAadharNumber { get; set; }
        public string LegalGaurdianSalutation { get; set; }
        public string LegalGaurdianFirstName { get; set; }
        public string LegalGaurdianMiddleName { get; set; }
        public string LegalGaurdianLastName { get; set; }
        public string LegalGaurdianMobileNumber { get; set; }
        public string LegalGaurdianOccupation { get; set; }
        public string LegalGaurdianOrganization { get; set; }
        public string LegalGaurdianDesignation { get; set; }
        public decimal LegalGaurdianAnnualIncome { get; set; }
        public string LegalGaurdianAadharNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}
