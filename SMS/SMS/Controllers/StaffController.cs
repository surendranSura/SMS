using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
//	[Authorize]
	//[AllowAnonymous]
	public class StaffController : ControllerBase
	{
		private readonly SchoolManagementContext _dbcontext;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public StaffController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SchoolManagementContext dbcontext)
		{
			this.userManager = userManager;
			this.roleManager = roleManager;
			this._dbcontext = dbcontext;
		}

		// GET: api/<StaffController>
		[HttpGet]
		public IEnumerable<Staff> Get()
		{
			return _dbcontext.Staffs.Include(X => X.Addresses).Include(g => g.experiences).ToList();
		}

		// GET api/<StaffController>/5
		[HttpGet("{id}")]
		public IActionResult Get(long id)
		{
			return Ok(_dbcontext.Staffs.Where(X => X.Mobile == id).Include(X => X.Addresses).Include(g => g.experiences).FirstOrDefault());
		}

		// POST api/<StaffController>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] Staff staff)
		{
			
			var userExists = await userManager.FindByNameAsync(staff.Mobile.ToString());
			if (userExists != null)
				return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "User already exists!" });

			ApplicationUser user = new ApplicationUser()
			{
				Email = staff.EmailId,
				SecurityStamp = Guid.NewGuid().ToString(),
				UserName = staff.Mobile.ToString(),
				Staff = staff
			};

			var result = await userManager.CreateAsync(user, staff.Mobile.ToString());

			if (result.Succeeded)
			{
				_dbcontext.Staffs.Add(staff);
				_dbcontext.SaveChanges();
			}

			return StatusCode(StatusCodes.Status200OK, new { Status = "Success", Message = "User added successfully!" });
		}

		// PUT api/<StaffController>/5
		[HttpPut("{id}")]
		public async Task Put(int id, [FromBody] Staff staff)
		{
			_dbcontext.Entry(_dbcontext.Staffs.Where(X => X.Mobile == id).FirstOrDefault()).CurrentValues.SetValues(staff);
			await _dbcontext.SaveChangesAsync();
		}

		// DELETE api/<StaffController>/5
		[HttpDelete("{id}")]
		public async Task Delete(long id)
		{
			_dbcontext.Remove(_dbcontext.Staffs.Where(X => X.Mobile == id).FirstOrDefault());
			await _dbcontext.SaveChangesAsync();
		}

		[HttpPost("PostStaffFeedback")]
		public async Task<IActionResult> PostStaffFeedback([FromBody] StaffFeedback staffFeedback)
		{
			_dbcontext.StaffFeedbacks.Add(staffFeedback);
			await _dbcontext.SaveChangesAsync();

			return Ok();
		}
	}
}
