using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSAPI.Authentication
{
	public interface IJwtAuthenticationManager
	{
		public void  Authenticate( ref Person person);
	}
}
