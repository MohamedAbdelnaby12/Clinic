using Clinic.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL
{
    public class ClinicDbContext : IdentityDbContext<Receptionist, IdentityRole<int>, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Clinic;Trusted_connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClinicDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

            // Configure identity tables to use int as primary key
            modelBuilder.Entity<Receptionist>().ToTable("Users");
            modelBuilder.Entity<IdentityRole<int>>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
