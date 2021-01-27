using Microsoft.EntityFrameworkCore;
using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS
{
	public class SchoolManagementdbcontext : DbContext
	{
		public DbSet<Function> Functions { get; set; }
		public DbSet<Person> Persons { get; set; }
		public DbSet<Role> Roles { get; set; }

		public DbSet<RoleFunction>  RoleFunctions { get; set; }
		public DbSet<Staff> Staffs { get; set; }

		public DbSet<Student> Students { get; set; }
	}
}
