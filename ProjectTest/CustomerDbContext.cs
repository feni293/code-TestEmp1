using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectTest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTest
{
    class CustomerDbContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public virtual DbSet<CustomerModel> Customer { get; set; }

        public CustomerDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = Configuration.GetConnectionString("TestConn");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerModel>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.IdentificationType).HasColumnName("IdentificationType");

                entity.Property(e => e.IdentificationNumber).HasColumnName("IdentificationNumber");

                entity.Property(e => e.CompanyName).HasColumnName("CompanyName");

                entity.Property(e => e.FirstName).HasColumnName("FirstName");

                entity.Property(e => e.SecondName).HasColumnName("SecondName");

                entity.Property(e => e.FirstLastName).HasColumnName("FirstLastName");

                entity.Property(e => e.SecondLastName).HasColumnName("SecondLastName");

                entity.Property(e => e.Email).HasColumnName("Email");

                entity.Property(e => e.esSendMessageCell).HasColumnName("esSendMessageCell");

                entity.Property(e => e.esSendMessageEmail).HasColumnName("esSendMessageEmail");
            });
        }

    }
}
