using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoJuegos.Models
{
    public class Usuarios
    {
        [Key]
        public int id_usuario { 
            get; set; 
        }

        public string nombre { 
            get; set; 
        }
        public bool genero { 
            get; set; 
        }
        public int edad { 
            get; set; 
        }


    }
}
