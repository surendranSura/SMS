using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SMS.Models;
using SMSAPI.Authentication;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
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
		private readonly UserManager<IdentityUser> userManager;
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly IConfiguration _configuration;

		public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration,
			           IJwtAuthenticationManager JwtAuthenticationManager, SchoolManagementContext dbcontext)
		{
			this._JwtAuthenticationManager = JwtAuthenticationManager;
			this._dbcontext = dbcontext;
			this.userManager = userManager;
			this.roleManager = roleManager;
			_configuration = configuration;
		}

		[AllowAnonymous]
		[HttpPost ("UserAuth")]
		[Route("api/[controller]/UserAuth")]
		[Consumes("application/json")]
		public async Task<IActionResult> UserAuth([FromBody]  ApplicationUser userCred)
		{

			var user = await userManager.FindByNameAsync(userCred.UserName);
			if (user != null && await userManager.CheckPasswordAsync(user, userCred.PasswordHash))
			{
				//UserCred _userCred;

				//StaffUserCred _staffUserCred = _dbcontext.StaffUserCreds.Where(X => X.Username == userCred.Username
				//                 && X.Password == userCred.Password).FirstOrDefault();

				//_userCred = _dbcontext.StaffUserCreds.Where(X => X. == userCred.UserName
				//						 && X.PasswordHash == userCred.Password).Select(X => new UserCred
				//						 {
				//							 Username = X.UserName,
				//							 Password = X.PasswordHash
				//						 }).FirstOrDefault();

				//if (_userCred == null)
				//{
				//	_userCred = _dbcontext.StudentUserCreds.Where(X => X.Username == userCred.Username
				//							 && X.Password == userCred.Password).Select(X => new UserCred
				//							 {
				//								 Username = X.Username,
				//								 Password = X.Password
				//							 }).FirstOrDefault();
				//}

				//if (_userCred == null)
				//	return Unauthorized();

				_JwtAuthenticationManager.Authenticate(ref userCred);

				return Ok(userCred);

			}
			return Unauthorized();


		}
	}
}
