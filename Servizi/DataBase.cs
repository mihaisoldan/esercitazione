using Microsoft.EntityFrameworkCore;
using Relazioni.Modello;

namespace Relazioni.Servizi{
    public class DataBase : DbContext{

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite(@"Data Source=../../../database.db;");
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Mossa>().ToTable("Mosse").HasKey(mossa => mossa.Id);
            builder.Entity<Tavolo>().ToTable("Tavoli").HasKey(tavolo => tavolo.Id);

            builder
                .Entity<Tavolo>()
                .HasMany(tavolo => tavolo.Mosse)
                .WithOne(mossa => mossa.Tavolo)
                .IsRequired();
            
        }
        
    }
}