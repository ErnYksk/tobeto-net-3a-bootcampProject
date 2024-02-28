﻿using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations; 

public class ApplicationStateConfiguration : IEntityTypeConfiguration<ApplicationState>
{
    public void Configure(EntityTypeBuilder<ApplicationState> builder)
    {
        builder.ToTable("ApplicationStates").HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ApplicationStateId");
        builder.Property(x => x.Name).HasColumnName("Name");

        builder.HasMany(x => x.Applications);

    }
}
