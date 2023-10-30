using System.ComponentModel.DataAnnotations;

namespace VideojuegosSergio.Models
{
    public class Video_juegos
    {
        [Key]
        public int id_videojuego { 
            get; set; 
        }
        public string nombre { 
            get; set; 
        }
        public string tipo_de_pago { 
            get; set; 
        }
        public bool es_grupal { 
            get; set; 
        }
        public string tipo { 
            get; set; 
        }

    }
}
