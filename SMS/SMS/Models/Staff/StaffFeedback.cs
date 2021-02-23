﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models
{
	public class StaffFeedback
	{
		[JsonIgnore]
		public int StaffFeedbackID { get; set; }
		public string Empid { get; set; }
		public string  StaffName { get; set; }

		public int FeedBackType { get; set; }

		public DateTime FeedBackDate { get; set; }

		public int Department { get; set; }

		public int TeacherId { get; set; }

		public string Description { get; set; }

		public byte[] Attachment { get; set; }
	}
}
