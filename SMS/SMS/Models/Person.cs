using System;
using System.Collections.Generic;

#nullable disable

namespace SMS.Models
{
    public partial class Person
    {
        public Person()
        {
            Students = new HashSet<Student>();
            Staff = new HashSet<Staff>();
        }

        public int PersonId { get; set; }
        public string EmailId { get; set; }
        public long Mobile { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
        public string Salt { get; set; }

		public string  AuthToken { get; set; }
		public string RoleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string AadharNumber { get; set; }
        public string BloodGroup { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }    }
}
