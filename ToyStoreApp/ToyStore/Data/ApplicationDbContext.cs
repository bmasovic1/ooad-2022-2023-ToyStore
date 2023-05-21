using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToyStore.Models;

namespace ToyStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Artikal> Artikal { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Kartica> Kartica { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Naplata> Naplata { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Artikal>().ToTable("Artikal");
            modelBuilder.Entity<Feedback>().ToTable("Feedback");
            modelBuilder.Entity<Kartica>().ToTable("Kartica");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Naplata>().ToTable("Naplata");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<RegistrovaniKorisnik>().ToTable("RegistrovaniKorisnik");
            modelBuilder.Entity<Uposlenik>().ToTable("Uposlenik");

            base.OnModelCreating(modelBuilder);
        }


    }
}
