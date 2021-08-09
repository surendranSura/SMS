﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models.Leave
{
	public class StaffLeave
	{
		public int StaffLeaveId { get; set; }

		[ForeignKey("StaffId")]
		public Staff Staffs { get; set; }

		public string LeaveType { get; set; }

		public DateTime datefrom { get; set; }

		public DateTime dateto { get; set; }

		public string leavesession { get; set; }

		public string Reason { get; set; }
	}
}
