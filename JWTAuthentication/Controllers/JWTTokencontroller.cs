using Microsoft.AspNetCore.Mvc;
using JWTAuthentication.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace JWTAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTTokencontroller : ControllerBase
    {
        public IConfiguration _configuration;
        public readonly Datadbcontext _context;

        public JWTTokencontroller(IConfiguration configuration ,Datadbcontext context)
        {
            _context = context;
            _configuration = configuration;
        }
            [HttpGet]
            [AllowAnonymous]
            public async Task<Register> GetUser(string UserName,int PassWord)
            {
                return await _context.Employees.FirstOrDefaultAsync(u =>u.username == UserName && u.password == PassWord);

            }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post(Register register)
        {
            if(register != null && register.username != null && register.password != null)
            {
                var userData = await GetUser( register.username,register.password);
                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                if (register !=null)
                {
                   var claims = new[]
                   {
                    new Claim(JwtRegisteredClaimNames.Sub,jwt.Subject),
                     new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                     new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                     new Claim("Id",register.userid.ToString()),
                     new Claim("UserName",register.username),
                     new Claim("Password",register.password.ToString())
                    
              };
              var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.key));
              var signIn = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
              var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires : DateTime.Now.AddMinutes(20),
                signingCredentials: signIn
              );
              return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else{
                    return BadRequest("InValied Credentials");
                }

            }
            else{
                return BadRequest("Invalid Credentials");
            }
           
        }

        
    }
}
