using Microsoft.AspNetCore.Mvc;
using ProyectoVideoJuegos.Models;
using VideojuegosSergio;
using VideojuegosSergio.Contexto;
using VideojuegosSergio.Models;

namespace VideojuegosSergio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Video_juegos_controller : ControllerBase
    {

        private readonly ILogger<Video_juegos_controller> _logger;

        private readonly Aplicacion_contexto _aplicacionContexto;
        public Video_juegos_controller(
            ILogger<Video_juegos_controller> logger,


            Aplicacion_contexto aplicacionContexto)
        {

            _logger = logger;

            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Video_juegos video_juegos)
        {
            _aplicacionContexto.Video_juegos.Add(video_juegos);

            _aplicacionContexto.SaveChanges();

            return Ok(video_juegos);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Video_juegos.ToList());

        }
        [Route("/id")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Video_juegos video_juegos)
        {
            _aplicacionContexto.Video_juegos.Update(video_juegos);


            _aplicacionContexto.SaveChanges();

            return Ok(video_juegos);
        }

        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int videoJuegosID)
        {
            _aplicacionContexto.Video_juegos.Remove(


                _aplicacionContexto.Video_juegos.ToList()
                .Where(x => x.id_videojuego == videoJuegosID)


                .FirstOrDefault());

            _aplicacionContexto.SaveChanges();

            return Ok(videoJuegosID);
        }
    }
}