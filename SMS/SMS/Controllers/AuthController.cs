using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SMS.Models;
using SMSAPI.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IJwtAuthenticationManager _JwtAuthenticationManager;
		private readonly SchoolManagementContext _dbcontext;

		public AuthController(IJwtAuthenticationManager JwtAuthenticationManager, SchoolManagementContext dbcontext)
		{
			this._JwtAuthenticationManager = JwtAuthenticationManager;
			this._dbcontext = dbcontext;
		}

		[AllowAnonymous]
		[HttpPost ("UserAuth")]
		[Route("api/[controller]/UserAuth")]
		[Consumes("application/json")]
		public IActionResult UserAuth([FromBody]  UserCred userCred)
		{
			Person _person = _dbcontext.Persons.Where(X => X.UserName == userCred.Username
			                 && X.Password == userCred.Password).FirstOrDefault();

			if (_person == null)
				return Unauthorized();

			_JwtAuthenticationManager.Authenticate(ref _person);

			return Ok(_person);
		}
	}
}
