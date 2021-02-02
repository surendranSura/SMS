using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
    public partial class Nationality
    {
		public Nationality()
		{
			People = new HashSet<Person>();
		}
		public int NationalityId { get; set; }
        public string NationalityName { get; set; }
		[JsonIgnore]
		[IgnoreDataMember]
		public virtual ICollection<Person> People { get; set; }
	}
}
