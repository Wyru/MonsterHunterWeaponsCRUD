using Microsoft.AspNetCore.Mvc;
using MonsterHunterWeaponsAPI.Request;
namespace MonsterHunterWeaponsAPI.Controllers
{
    public class DefaultController : ControllerBase
    {
        public IActionResult BuildResponse<T> (Func<Object> action) {
            try {

                var result = action.Invoke();

                return Ok(result);
            }
            catch (Exception) {
                return StatusCode(500, new {
                    success = false,
                    message = "Internal server error!"
                });
            }
        }
    }
}
