using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ReconUtility_Core.Recon.Models;

namespace Recon.Repository.Infrastructure
{
    public class ReconDB:DbContext
    {
      
        public ReconDB(DbContextOptions<ReconDB> options) : base(options)
        {
        }

        public DbSet<Billing> Billings { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<ReInsurancePolicy> ReInsurancePolicies { get; set; }
        public DbSet<ReInsuranceClaim> ReInsuranceClaims { get; set; }
        public DbSet<Claims> claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billing>().ToTable("Billing");
            modelBuilder.Entity<Policy>().ToTable("Policy");
            modelBuilder.Entity<ReInsurancePolicy>().ToTable("ReInsurancePolicy");
            modelBuilder.Entity<ReInsuranceClaim>().ToTable("ReInsuranceClaim");
            modelBuilder.Entity<ReInsuranceClaim>().HasKey(n => new { n.ClaimNo, n.CompClaimNo });
            modelBuilder.Entity<Claims>().ToTable("Claims");
        }

    }
}
