using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSAPI.Authentication;
using SMSAPI.Models;
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
		public AuthController(IJwtAuthenticationManager JwtAuthenticationManager)
		{
			this._JwtAuthenticationManager = JwtAuthenticationManager;

		}

		[AllowAnonymous]
		[HttpPost ("UserAuth")]
		[Route("api/[controller]/UserAuth")]
		[Consumes("application/json")]
		public IActionResult UserAuth([FromBody]  UserCred userCred)
		{
			var token = _JwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);

			if (token == null)
				return Unauthorized();

			return Ok(token);
		}
	}
}
