using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MonsterHunterWeaponsAPI.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class AuthController : ControllerBase
  {

    private IConfiguration _config;
    public AuthController(IConfiguration Configuration)
    {
      _config = Configuration;
    }

    [HttpPost]
    [AllowAnonymous]
    public string Post()
    {

      var issuer = _config["Jwt:Issuer"];
      var audience = _config["Jwt:Audience"];
      var expiry = DateTime.Now.AddMinutes(120);
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Secret"]));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var token = new JwtSecurityToken(
        issuer: issuer,
        audience: audience,
        expires: DateTime.Now.AddMinutes(Double.Parse(_config["Jwt:LifetimeMinutes"])),
        signingCredentials: credentials
      );

      var tokenHandler = new JwtSecurityTokenHandler();
      var stringToken = tokenHandler.WriteToken(token);

      return stringToken;
    }
  }
}