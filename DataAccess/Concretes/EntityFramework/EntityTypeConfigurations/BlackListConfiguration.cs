using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class BlackListConfiguration : IEntityTypeConfiguration<BlackList>
{
    public void Configure(EntityTypeBuilder<BlackList> builder)
    {
        builder.ToTable("BlackList");
        builder.Property(x => x.ApplicantId).HasColumnName("ApplicantId");
        builder.Property(x => x.Reason).HasColumnName("Reason");
        builder.Property(x => x.Date).HasColumnName("Date");

        builder.HasOne(x => x.Applicant);

    }
}
