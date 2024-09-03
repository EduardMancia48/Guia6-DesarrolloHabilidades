using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Guia6_Desarrollo.Models
{
    public class Autor
    {
        public int AutorID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        public ICollection<Libro> Libros { get; set; }  // Relación uno a muchos

    }
}
