﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models
{
	public class UserCred
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public string AuthToken { get; set; }
	}
}
