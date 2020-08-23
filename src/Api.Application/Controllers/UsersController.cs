using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        protected readonly IUserService _service;

        public UsersController (IUserService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll () {
            try {
                return Ok (await _service.GetAll ());
            } catch (ArgumentException ex) {
                return StatusCode ((int) HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
