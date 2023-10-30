using System.ComponentModel.DataAnnotations;

namespace VideojuegosSergio.Models
{
    public class Email
    {
        [Key]
        public int id_email { 
            get; set; 
        }
        public string email { 
            get; set; 
        }

    }
}
