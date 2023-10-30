using Microsoft.AspNetCore.Mvc;
using ProyectoVideoJuegos.Models;
using VideojuegosSergio;
using VideojuegosSergio.Contexto;
using VideojuegosSergio.Models;

namespace VideojuegosSergio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Usuario_controlador : ControllerBase
    {

        private readonly ILogger<Usuario_controlador> _logger;

        private readonly Aplicacion_contexto _aplicacionContexto;
        public Usuario_controlador(
            ILogger<Usuario_controlador> logger,


            Aplicacion_contexto aplicacionContexto)
        {

            _logger = logger;

            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuarios usuarios)
        {
            _aplicacionContexto.Usuarios.Add(usuarios);

            _aplicacionContexto.SaveChanges();

            return Ok(usuarios);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Usuarios.ToList());

        }
        [Route("/id")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Usuarios usuarios)
        {
            _aplicacionContexto.Usuarios.Update(usuarios);


            _aplicacionContexto.SaveChanges();

            return Ok(usuarios);
        }

        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int usuariosID)
        {
            _aplicacionContexto.Usuarios.Remove(


                _aplicacionContexto.Usuarios.ToList()
                .Where(x => x.id_usuario == usuariosID)


                .FirstOrDefault());

            _aplicacionContexto.SaveChanges();

            return Ok(usuariosID);
        }
    }
}