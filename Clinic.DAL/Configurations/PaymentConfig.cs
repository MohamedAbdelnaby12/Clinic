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
    internal class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            //Relations
          builder
         .HasOne(p => p.Appointment)
         .WithOne(a => a.Payment)
         .HasForeignKey<Appointment>(a => a.PaymentId);
        }
    }
}
