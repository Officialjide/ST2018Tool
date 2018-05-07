using IceLux.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IceLux.Infrastructure.EntityConfigurations
{
    public class FirmConfiguration : IEntityTypeConfiguration<Firm>
    {
        //IEntityTypeConfiguration<File>
        public void Configure(EntityTypeBuilder<Firm> builder)
        {
            throw new NotImplementedException();
            /*builder.ToTable("File");            

        // Id
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
               .ValueGeneratedOnAdd();

        // Message
        builder.HasOne(c => c.Message)
               .WithOne(c => c.File)
               .HasForeignKey<Message>(c => c.MessageId)
               .OnDelete(DeleteBehavior.Restrict);*/
        }       
    }
}
