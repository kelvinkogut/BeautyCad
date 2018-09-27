namespace Inicial
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Inicial.Models;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer<ModelContext>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ControleFin> ControleFins { get; set; }
        public DbSet<Models.Funcionarios> Funcionarios { get; set; }
        public DbSet<Horarios> Horarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Horarios>().HasMany<Servico>(s => s.Servicos).WithMany(c => c.ListHorarios).Map(cs =>
            {
                cs.MapLeftKey("Horarios_ID");
                cs.MapRightKey("Servico_ID");
                cs.ToTable("ServicoHorarios");
            });
        }

    }
}
