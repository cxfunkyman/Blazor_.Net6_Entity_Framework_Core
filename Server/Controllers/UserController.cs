using Blazor_.Net6_Entity_Framework_Core.Server.Interfaces;
using Blazor_.Net6_Entity_Framework_Core.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_.Net6_Entity_Framework_Core.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _IUser;

        public UserController(IUser iUser)
        {
            _IUser = iUser;
        }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await Task.FromResult(_IUser.GetUsersDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = _IUser.GetUserData(id);

            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }

        [HttpPost]
        public void Post(User user)
        {
            _IUser.AddUser(user);
        }

        [HttpPut]
        public void Put(User user)
        {
            _IUser.UpdateUserDetails(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IUser.DeleteUser(id);
            return Ok();
        }
    }
}
