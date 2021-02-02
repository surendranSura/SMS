using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#nullable disable

namespace SMS.Models
{
    public partial class Religion
    {
		public Religion()
		{
			People = new HashSet<Person>();
		}
		public int ReligionId { get; set; }
        public string ReligionName { get; set; }

		[JsonIgnore]
		[IgnoreDataMember]
		public virtual ICollection<Person> People { get; set; }
	}
}
