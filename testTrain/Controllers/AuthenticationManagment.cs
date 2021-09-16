using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using System.Text;

using testTrain.Configuration;
using testTrain.Model.DOTs.Response;
using testTrain.Model;

namespace testTrain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationManagment : ControllerBase
    {

        private readonly UserManager<DelieveryMan> _userManager;
      
        private readonly JwtConfig jwtConfig;
        public AuthenticationManagment(UserManager<DelieveryMan> userManager,IOptionsMonitor<JwtConfig> optionMonitor)
        {
            this._userManager = userManager;

            jwtConfig = optionMonitor.CurrentValue;

        }
        //[HttpPost]
        //[Route("Register")]
        //public async Task<IActionResult> Register(delieveryMan user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var existingUser = await _userManager.FindByIdAsync(user.PhoneNumber);
        //        if (existingUser != null)
        //        {
        //            return BadRequest(new LoginResponse()
        //            {
        //                Errors = new List<string>()
        //                {
        //                     "NationalID already in use"
        //                },
        //                Success = false

        //            });
        //        }

        //        var newUser = new delieveryMan() {  PhoneNumber = user.PhoneNumber };
        //        var isCreated = await _userManager.CreateAsync(newUser, user.PasswordHash);
        //        if (isCreated.Succeeded)
        //        {
        //            var jwtToken = GenerateJwtToken(newUser);
        //            return Ok(new LoginResponse()
        //            {
        //                Success = true,
        //                Token = jwtToken

        //            });

        //        }
        //        else
        //        {
        //            return BadRequest(new LoginResponse()
        //            {
        //                Errors = new List<string>()
        //                {
        //                     "Invalid "
        //                },
        //                Success = false

        //            });
        //        }

        //    }
        //    return BadRequest(new LoginResponse()
        //    {
        //        Errors = new List<string>()
        //                {
        //                     "Invalid "
        //                },
        //        Success = false

        //    });


        //}
        [HttpPost]
        [Route("Login")]
       
        public async Task<IActionResult> Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {


                var existingUser = await _userManager.FindByNameAsync(user.PhoneNumber);
                if (existingUser == null)
                {

                    return BadRequest(new LoginResponse()
                    {
                        Errors = new List<string>()
                        {
                             "Invalid login request"
                        },
                        Success = false

                    });
                }
                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.password);
                if (!isCorrect)
                {
                    return BadRequest(new LoginResponse()
                    {
                        Errors = new List<string>()
                        {
                             "Invalid login request"
                        },
                        Success = false

                    });
                }
                var jwtToken = GenerateJwtToken(existingUser);
                return Ok(new LoginResponse()
                {
                    Success = true,
                    Token = jwtToken

                });
            }
            return BadRequest(new LoginResponse()
            {
                Errors = new List<string>()
                        {
                             "Invalid "
                        },
                Success = false

            });
        }

        private string GenerateJwtToken(DelieveryMan user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                new Claim("Id",user.Id),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            return jwtToken;

        }
    }
}

