using System;
using Sev1.Congratulations.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sev1.Congratulations.DataAccess.EntitiesConfiguration
{
    public class UserFileConfiguration : IEntityTypeConfiguration<UserFile>
    {
        public void Configure(EntityTypeBuilder<UserFile> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}