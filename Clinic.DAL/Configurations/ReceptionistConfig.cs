using Clinic.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Configurations
{
    public class ReceptionistConfig : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> builder)
        {
            builder.Property(D => D.Name).IsRequired();
            builder.Property(D => D.Phone)
            .IsRequired()
            .HasMaxLength(15)
            .HasAnnotation("RegularExpression", @"^(?:\+20|0)?1[0-9]{9}$");
        }
    }
}
