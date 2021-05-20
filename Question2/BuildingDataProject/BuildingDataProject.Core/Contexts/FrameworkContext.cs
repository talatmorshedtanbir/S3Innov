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
            builder.Entity<EmailReport>()
                .HasOne<Campaign>(c => c.Campaign)
                .WithMany(e => e.EmailReports)
                .HasForeignKey(c => c.CampaignId);

            builder.Entity<GroupContact>()
                .HasKey(gc => new { gc.GroupId, gc.ContactId });

            base.OnModelCreating(builder);

        }

        public DbSet<Smtp> Smtps { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<GroupContact> GroupContacts { get; set; }
        public DbSet<ValueMap> ValueMaps { get; set; }
        public DbSet<MapField> MapFields { get; set; }
    }
}
