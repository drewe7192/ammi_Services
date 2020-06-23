using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmmiServices.Models;
using AmmiServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmmiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get() =>
            _usersService.Get();

        [HttpGet("{id:length(24)}",Name = "GetUser")]
        public ActionResult<User> Get(string id)
        {
            var user = _usersService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }


        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _usersService.Create(user);
            return CreatedAtRoute("GetUser", new { id = user.Id.ToString() }, user);
        }

    }
}