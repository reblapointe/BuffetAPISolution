using BuffetAPI.Auth;
using BuffetAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuffetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController(IAuthManager authManager, ILogger<AccountsController> logger) : ControllerBase
    {
        private readonly IAuthManager _authManager = authManager;
        private readonly ILogger _logger = logger;

        // POST: api/Account/register-ogre
        [HttpPost]
        [Route("register-ogre")]
        public async Task<ActionResult> RegisterOgre([FromBody] Register register)
        {
            _logger.LogInformation("Tentative d'enregistrement d'un nouvel ogre pour {email}, {name}", register.Email, register.Username);
            var errors = await _authManager.RegisterOgre(register);
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Ok();
        }

        // POST: api/Account/register-cuisinier
        [HttpPost]
        [Route("register-cuisinier")]
        public async Task<ActionResult> RegisterCuisinier([FromBody] Register register)
        {
            _logger.LogInformation("Tentative d'enregistrement d'un nouveau cuisinier pour {email}, {name}", register.Email, register.Username);
            var errors = await _authManager.RegisterCuisinier(register);
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Ok();
        }

        // POST: api/Account/register
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login([FromBody] Login login)
        {
            var authResponse = await _authManager.Login(login);
            if (authResponse is null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }
    }
}