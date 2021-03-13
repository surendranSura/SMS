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
	[AllowAnonymous]
	//[Authorize]
	public class StudentController : ControllerBase
	{
		private readonly SchoolManagementContext _dbcontext;
		
		public StudentController(SchoolManagementContext dbcontext)
		{
			this._dbcontext = dbcontext;
		}
		// GET: api/<StudentController>
		[HttpGet]
		public IEnumerable<Student> Get()
		{
			return _dbcontext.Students.ToList();
		}

		// GET api/<StudentController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_dbcontext.Students.Where(X => X.AdmissionNumber == id).FirstOrDefault());
		}

		// POST api/<StudentController>
		[HttpPost]
		[AllowAnonymous]
		public void Post([FromBody] Student student)
		{
			_dbcontext.Students.Add(student);
			_dbcontext.SaveChanges();
		}

		// PUT api/<StudentController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Student student)
		{
			_dbcontext.Entry(_dbcontext.Students.Where(X => X.AdmissionNumber == id).FirstOrDefault()).CurrentValues.SetValues(student);
			_dbcontext.SaveChanges();
		}

		// DELETE api/<StudentController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_dbcontext.Remove(_dbcontext.Students.Where(X => X.AdmissionNumber == id).FirstOrDefault());
			_dbcontext.SaveChanges();
		}
	}
}
