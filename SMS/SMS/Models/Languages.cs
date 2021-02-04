using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models
{
	public class Languages
	{
		//public Languages()
		//{
		//	staff = new HashSet<Staff>();
		//}

		public int LanguagesId { get; set; }

		public string LanguageDescription { get; set; }

		//[JsonIgnore]
		//[IgnoreDataMember]
		//public virtual ICollection<Staff> staff { get; set; }
	}
}
