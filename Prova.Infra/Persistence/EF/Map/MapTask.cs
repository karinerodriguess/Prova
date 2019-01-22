using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Infra.Persistence.EF.Map
{
    public class MapTask : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
        }
    }
}
