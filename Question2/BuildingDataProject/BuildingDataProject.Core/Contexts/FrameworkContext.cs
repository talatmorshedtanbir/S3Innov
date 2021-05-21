using BuildingDataProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingDataProject.Core.Contexts
{
    public class FrameworkContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Reading>()
                .HasKey(x => new { x.BuildingId, x.ObjectId, x.DataFieldId });
            builder.Entity<Reading>()
                .HasOne<Building>(c => c.Building)
                .WithMany(e => e.Readings)
                .HasForeignKey(c => c.BuildingId);
            builder.Entity<Reading>()
                .HasOne<Entities.Object>(c => c.Object)
                .WithMany(e => e.Readings)
                .HasForeignKey(c => c.ObjectId);
            builder.Entity<Reading>()
                .HasOne<DataField>(c => c.DataField)
                .WithMany(e => e.Readings)
                .HasForeignKey(c => c.DataFieldId);

            base.OnModelCreating(builder);
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Entities.Object> Objects { get; set; }
        public DbSet<DataField> DataField { get; set; }

    }
}
