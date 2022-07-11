using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MonsterHunterWeaponsAPI.Request;
namespace MonsterHunterWeaponsAPI.Controllers
{

  [ApiController]
  [Route("[controller]")]
  [Authorize]
  public class CreateWeaponController : ControllerBase
  {
    [HttpPost]
    public IActionResult Index([FromBody] CreateWeaponRequest request)
    {
      try
      {

        //request.Validate();

        //throw new Exception();

        return Ok(
            new
            {
              success = true,
              message = "Weapon successfully registered!"
            });
      }
      catch (Exception)
      {
        return StatusCode(500, new
        {
          success = false,
          message = "Internal server error!"
        });
      }
    }
  }
}
