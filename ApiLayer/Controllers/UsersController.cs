using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace ApiLayer.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult> Register([FromForm] User user, [FromQuery] string password)
        {
            try
            {
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return Ok();
                }
                else
                {
                    List<string> errors = new List<string>();
                    foreach (var error in result.Errors)
                    {
                        errors.Add(error.Description);
                    }
                    return BadRequest(errors);
                }
            }
            catch
            {
                return BadRequest("User already exists");
            }
        }

        [AllowAnonymous]
        [HttpPost("Token")]
        public async Task<ActionResult> GetToken([FromQuery] string username, [FromQuery] string password)
        {
            ClaimsIdentity identity = await GetIdentity(username, password);
            if (identity == null)
            {
                return BadRequest("Invalid username or password.");
            }
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
                username = username
            };
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
                if (result.Succeeded)
                {
                    //var user = await _userManager.FindByNameAsync(username);
                    return Ok();
                }
                else
                {
                    return BadRequest("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Logout")]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet("{UserName}", Name = "UserByName")]
        public async Task<ActionResult<User>> UserByName(string userName)
        {
            User user = null;
            try
            {
                user = await _userManager.FindByNameAsync(userName);
                if (user == null)
                    return NotFound("User is not found");
            }
            catch
            {
                return BadRequest();
            }
            return Ok(user);
        }

        //[Authorize(Roles = "Admin")]
        //[HttpGet("{Id}", Name = "UserById")]
        //public async Task<ActionResult<User>> UserById([FromQuery]string id)
        //{
        //    User user = null;
        //    try
        //    {
        //        user = await _userManager.FindByIdAsync(id);
        //        if (user == null)
        //            return NotFound("User is not found");
        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(user);
        //}

        [HttpPut("Update")]
        public async Task<ActionResult> Update([FromBody] User user)
        {

            try
            {
                var targetUser = await _userManager.FindByIdAsync(user.Id);
                if (targetUser != null)
                {
                    await _userManager.UpdateAsync(user);
                    return Ok();
                }
                else
                {
                    return NotFound("User is not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize(Roles = "Admin")]
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var targetUser = await _userManager.FindByIdAsync(id);
                if (targetUser != null)
                {
                    await _userManager.DeleteAsync(targetUser);
                    return Ok();
                }
                else
                {
                    return NotFound("User is not found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private async Task<ClaimsIdentity> GetIdentity(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var claims = await _userManager.GetClaimsAsync(user);
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            else
                return null;
        }

    }
}
