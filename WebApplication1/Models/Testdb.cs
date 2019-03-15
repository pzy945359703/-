namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Testdb : DbContext
    {
        public Testdb()
            : base("name=Testdb")
        {
        }


        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
    public class TestDB
    {
        public string AccountNumber { get; set; }
        public string Password { get; set; }
       

    }
}
