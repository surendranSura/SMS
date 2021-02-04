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
			UserCred _userCred;

			//StaffUserCred _staffUserCred = _dbcontext.StaffUserCreds.Where(X => X.Username == userCred.Username
			//                 && X.Password == userCred.Password).FirstOrDefault();

			_userCred = _dbcontext.StaffUserCreds.Where(X => X.Username == userCred.Username
									 && X.Password == userCred.Password).Select(X => new UserCred
									 {
										 Username = X.Username,
										 Password = X.Password
									 }).FirstOrDefault();

			if (_userCred == null)
			{
				_userCred = _dbcontext.StudentUserCreds.Where(X => X.Username == userCred.Username
										 && X.Password == userCred.Password).Select(X => new UserCred
										 {
											 Username = X.Username,
											 Password = X.Password
										 }).FirstOrDefault();
			}

			if (_userCred == null)
				return Unauthorized();

			_JwtAuthenticationManager.Authenticate(ref _userCred);

			return Ok(_userCred);
		}
	}
}
