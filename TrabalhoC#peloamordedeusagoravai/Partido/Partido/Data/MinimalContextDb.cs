using Microsoft.EntityFrameworkCore;
using Partido.models;

namespace Partido.Data
{
    public class MinimalContextDb : DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        public DbSet<Militante> Militantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Militante>()
                .HasKey(p => p.Id);


            modelBuilder.Entity<Militante>()
                .Property(p => p.Email)
                .IsRequired();



            modelBuilder.Entity<Militante>()
                .Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Militante>()
                .Property(p => p.Nasc)
                .IsRequired()
                .HasColumnType("varchar(8)");

            modelBuilder.Entity<Militante>()
                .ToTable("Fornecedores");

            base.OnModelCreating(modelBuilder);


        }


    }

  
}
