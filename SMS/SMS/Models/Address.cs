using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models
{
	public class Address
	{
		public Address()
		{
			People = new HashSet<Person>();
		}

		[JsonIgnore]
		[IgnoreDataMember]
		public int AddressId { get; set; }
		[JsonIgnore]
		[IgnoreDataMember]
		public int PersonId { get; set; }
		public string Line1 { get; set; }

		public string Line2 { get; set; }

		public string Line3 { get; set; }

		public string City { get; set; }

		public string Sate { get; set; }

		public string Country { get; set; }

		public string Pincode { get; set; }
		[JsonIgnore]
		[IgnoreDataMember]
		public virtual ICollection<Person> People { get; set; }

	}
}
