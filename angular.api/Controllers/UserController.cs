using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using angular.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace angular.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new {
                Nombre = "Pedro",
                Apellido = "Perez",
                Email = "prueba@angular.com"
            });
        }

        // GET api/values/5
        [HttpGet("users")]
        public ActionResult GetUsers()
        {

            List<UserViewModel> users = new List<UserViewModel>();

            users.Add(new UserViewModel
            {
                Apellido = "garcia",
                Email = "email@email.com",
                Nombre = "Federico"
            });

            users.Add(new UserViewModel
            {
                Apellido = "garcia",
                Email = "email@email.com",
                Nombre = "Lucas"
            });

            users.Add(new UserViewModel
            {
                Apellido = "garcia",
                Email = "email@email.com",
                Nombre = "Redrigo"
            });

            return Ok(users);
        }

        [HttpPost("adduser")]
        public ActionResult Adduser([FromBody] UserViewModel user)
        {

            return Ok();
        }


        [HttpPost("image")]
        public async Task<ActionResult> PostImage(IFormFile image)
        {

            var filepath = Path.GetTempFileName();

            using (var stream = new FileStream(filepath, FileMode.Create))
            {

                await image.CopyToAsync(stream);
            }

            //Realizaremos la accion que queramos

            return Ok();
        }



    }
}
