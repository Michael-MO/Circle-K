namespace WebService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CircleKDBContext : DbContext
    {
        public CircleKDBContext()
            : base("name=CircleKDBContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Station> Stations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Stations)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.AccessLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.TerminationReason)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.DeletionDate)
                .HasColumnType("date");

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Masters)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Station>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Masters)
                .WithRequired(e => e.Station)
                .WillCascadeOnDelete(false);
        }
    }
}
