using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
    public partial class Person
    {
        public Person()
        {
            Students = new HashSet<Student>();
            staff = new HashSet<Staff>();
        }
        [IgnoreDataMember]
        [JsonIgnore]
        public int PersonId { get; set; }
        public string EmailId { get; set; }
        public long Mobile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AuthToken { get; set; }
        public string RoleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string AadharNumber { get; set; }
        public string BloodGroup { get; set; }
        public int? NationalityId { get; set; }
        public int? ReligionId { get; set; }

        public virtual Nationality Nationality { get; set; }
        public virtual Religion Religion { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public int AddressId { get; set; }
		public Address[] CurrentAddress { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Student> Students { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Staff> staff { get; set; }
    }
}
