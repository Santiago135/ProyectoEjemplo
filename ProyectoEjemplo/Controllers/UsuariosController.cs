using ApplicationCore.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoEjemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController(IUsuariosService usuariosService) : ControllerBase
    {
        // GET: api/<UsuariosController>
        [HttpGet("listar")]
        public async Task<List<Usuario>> GetUsuarios()
        {
            var usuarios = await usuariosService.GetUsuarios();
            return usuarios;
        }

        // GET api/<UsuariosController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UsuariosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UsuariosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuariosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
