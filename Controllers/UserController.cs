using ApiInterciclo.Entities;
using ApiInterciclo.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInterciclo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly Datacontext _datacontext;
        public UserController(Datacontext datacontext)
        {
            _datacontext = datacontext;
        }

        [HttpGet("auth/{username}/{password}")]
        public async Task<ActionResult> authAsync(string username, string password)
        {
            User usario = await _datacontext.User.FirstOrDefaultAsync(x => x.username == username && x.password == password);
            if (usario != null)
            {
                return Ok(usario);
            }
            else
            {
                return BadRequest("Error en autentificar");
            }
        }


        [HttpGet("alluser")]
        public async Task<ActionResult> AllUser()
        {
            List<User> usario = await _datacontext.User.ToListAsync();
            if (usario != null)
            {
                return Ok(usario);
            }
            else
            {
                return BadRequest("Error en autentificar");
            }
        }
    }
}
