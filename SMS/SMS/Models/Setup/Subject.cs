using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models.Setup
{
	public class Subject
	{
		//[JsonIgnore]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SubjectID { get; set; }
		public string SubjectDescr { get; set; }
	}
}
