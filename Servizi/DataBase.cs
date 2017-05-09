using Microsoft.EntityFrameworkCore;
using Relazioni.Modello;

namespace Relazioni.Servizi{
    public class DataBase : DbContext{

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            builder.UseSqlite(@"Data Source=../../../database.db;");
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Mossa>().ToTable("Mosse").HasKey(mossa => mossa.Id);
        }
        
    }
}