using System.ComponentModel.DataAnnotations;

namespace Guia6_Desarrollo.Models
{
    public class Libro
    {
        public int LibroID { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        public int AutorID { get; set; }  // Clave foránea
        public Autor Autor { get; set; }

        public int CategoriaID { get; set; }  // Clave foránea
        public Categoria Categoria { get; set; }
    }
}
