using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class FactoryController : ControllerBase
	{
		private readonly SchoolManagementContext _dbcontext;

		public FactoryController(SchoolManagementContext dbcontext)
		{
			this._dbcontext = dbcontext;
		}

		#region Religion
		// GET: api/<FactoryController>
		[HttpGet("Religions")]
		public IEnumerable<Religion> Religions()
		{
			return _dbcontext.Religions.ToList();
		}
		#endregion

		#region Nationality

		[HttpGet("Nationalities")]
		public IEnumerable<Nationality> Nationalities()
		{
			return _dbcontext.Nationalities.ToList();
		}
		#endregion

		#region Department

		[HttpGet("Departments")]
		public IEnumerable<Department> Departments()
		{
			return _dbcontext.Departments.ToList();
		}
		#endregion

		#region Designation

		[HttpGet("Designations")]
		public IEnumerable<Designation> Designations()
		{
			return _dbcontext.Designations.ToList();
		}
		#endregion
		// GET api/<FactoryController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<FactoryController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<FactoryController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<FactoryController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
