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
	public class StaffController : ControllerBase
	{
		private readonly SchoolManagementContext _dbcontext;

		public StaffController(SchoolManagementContext dbcontext)
		{
			this._dbcontext = dbcontext;
		}
		// GET: api/<StaffController>
		[HttpGet]
		public IEnumerable<Staff> Get()
		{
			return _dbcontext.Staffs.ToList();
		}

		// GET api/<StaffController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_dbcontext.Staffs.Where(X => X.StaffId == id).FirstOrDefault());
		}

		// POST api/<StaffController>
		[HttpPost]
		public void Post([FromBody] Staff staff)
		{
			_dbcontext.Staffs.Add(staff);
			_dbcontext.SaveChanges();
		}

		// PUT api/<StaffController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Staff staff)
		{
			_dbcontext.Entry(_dbcontext.Staffs.Where(X => X.StaffId == id).FirstOrDefault()).CurrentValues.SetValues(staff);
			_dbcontext.SaveChanges();
		}

		// DELETE api/<StaffController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_dbcontext.Remove(_dbcontext.Staffs.Where(X => X.StaffId == id).FirstOrDefault());
			_dbcontext.SaveChanges();
		}
	}
}
