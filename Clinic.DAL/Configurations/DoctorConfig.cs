﻿using Clinic.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Configurations
{
    internal class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(D => D.Name).IsRequired();
            builder.Property(D => D.Phone)
            .IsRequired()
            .HasMaxLength(15) 
            .HasAnnotation("RegularExpression", @"^(?:\+20|0)?1[0-9]{9}$");

            //Relations
            builder
           .HasOne(D => D.Schedule)
           .WithOne(m => m.Doctor)
           .HasForeignKey<Doctor>(m => m.ScheduleId);


        }
    }
}
