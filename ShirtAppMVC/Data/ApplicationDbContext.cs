using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShirtAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShirtAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {
            base.OnModelCreating(Modelbuilder);

            Modelbuilder.Entity<Shirt>().ToTable("Shirt");
            Modelbuilder.Entity<Transaction>().ToTable("Transaction");
        }
    }
}
