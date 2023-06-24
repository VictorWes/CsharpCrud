using CRUD_Csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Csharp.Data
{
    public class SistemaTarefasDB : DbContext
    {
        public SistemaTarefasDB(DbContextOptions<SistemaTarefasDB> options)
            : base (options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefasModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
