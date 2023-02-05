using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5_RPG.Data;
using Dotnet5_RPG.Dtos.User;
using Dotnet5_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet5_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
       public AuthController(IAuthRepository authRepo)
       {
            _authRepo = authRepo;
        
       } 

        [HttpPost("Register")]
       public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
       {
            var response = await _authRepo.Register(
                new User{Username = request.Username}, request.Password
            );
            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
       }

        [HttpPost("Login")]
       public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
       {
            var response = await _authRepo.Login(
                request.Username, request.Password
            );
            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
       }
    }
}