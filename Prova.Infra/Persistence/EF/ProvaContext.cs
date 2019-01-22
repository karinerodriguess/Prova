using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using Prova.Domain.Entities;
using Prova.Infra.Persistence.EF.Map;
using Prova.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Infra.Persistence.EF
{
    public class ProvaContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new MapTask());

            base.OnModelCreating(modelBuilder);
        }
    }
}
