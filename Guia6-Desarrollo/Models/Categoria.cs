using System.ComponentModel.DataAnnotations;

namespace Guia6_Desarrollo.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}
