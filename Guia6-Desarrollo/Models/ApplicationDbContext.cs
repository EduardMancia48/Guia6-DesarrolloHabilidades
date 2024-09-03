using Microsoft.EntityFrameworkCore;
namespace Guia6_Desarrollo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos iniciales para Autores
            modelBuilder.Entity<Autor>().HasData(
                new Autor { AutorID = 1, Nombre = "Gabriel", Apellido = "García Márquez" },
                new Autor { AutorID = 2, Nombre = "Isabel", Apellido = "Allende" },
                new Autor { AutorID = 3, Nombre = "J.K.", Apellido = "Rowling" },
                new Autor { AutorID = 4, Nombre = "George", Apellido = "Orwell" },
                new Autor { AutorID = 5, Nombre = "Jane", Apellido = "Austen" }
            );

            // Datos iniciales para Categorías
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaID = 1, Nombre = "Ficción" },
                new Categoria { CategoriaID = 2, Nombre = "Ciencia Ficción" },
                new Categoria { CategoriaID = 3, Nombre = "Fantasía" },
                new Categoria { CategoriaID = 4, Nombre = "Histórico" },
                new Categoria { CategoriaID = 5, Nombre = "Romance" }
            );

            // Datos iniciales para Libros
            modelBuilder.Entity<Libro>().HasData(
                new Libro { LibroID = 1, Titulo = "Cien Años de Soledad", FechaPublicacion = new DateTime(1967, 5, 30), AutorID = 1, CategoriaID = 1 },
                new Libro { LibroID = 2, Titulo = "La Casa de los Espíritus", FechaPublicacion = new DateTime(1982, 1, 1), AutorID = 2, CategoriaID = 4 },
                new Libro { LibroID = 3, Titulo = "Harry Potter y la Piedra Filosofal", FechaPublicacion = new DateTime(1997, 6, 26), AutorID = 3, CategoriaID = 3 },
                new Libro { LibroID = 4, Titulo = "1984", FechaPublicacion = new DateTime(1949, 6, 8), AutorID = 4, CategoriaID = 2 },
                new Libro { LibroID = 5, Titulo = "Orgullo y Prejuicio", FechaPublicacion = new DateTime(1813, 1, 28), AutorID = 5, CategoriaID = 5 }
            );
        }
    }
}