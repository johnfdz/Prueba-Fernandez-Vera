using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pruebas1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]  
        public String NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String clave { get; set; }
        [Required]
        public Boolean estado { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
