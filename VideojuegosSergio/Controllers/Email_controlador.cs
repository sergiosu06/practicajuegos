using Microsoft.AspNetCore.Mvc;
using VideojuegosSergio;
using VideojuegosSergio.Contexto;
using VideojuegosSergio.Models;

namespace VideojuegosSergio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Email_controlador : ControllerBase
    {

        private readonly ILogger<Email_controlador> _logger;
        
        private readonly Aplicacion_contexto _aplicacionContexto;
        public Email_controlador(
            ILogger<Email_controlador> logger,

            
            Aplicacion_contexto aplicacionContexto)
        {
            
            _logger = logger;
            
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Add(email);

            _aplicacionContexto.SaveChanges();

            return Ok(email);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Email.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Update(email);

            
            _aplicacionContexto.SaveChanges();
            
            return Ok(email);
        }
        
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int emailId)
        {
            _aplicacionContexto.Email.Remove(

                
                _aplicacionContexto.Email.ToList()
                .Where(x => x.id_email == emailId)

                
                .FirstOrDefault());
            
            _aplicacionContexto.SaveChanges();
            
            return Ok(emailId);
        }
    }
}
