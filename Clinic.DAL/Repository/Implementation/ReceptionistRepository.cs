using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.Repository.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.Repository.Implementation
{
    public class ReceptionistRepository : GenericRepository<Receptionist>, IReceptionistRepository
    {
        private readonly ClinicDbContext _clinicDbContext;
        private readonly UserManager<Receptionist> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public ReceptionistRepository(ClinicDbContext clinicDbContext,UserManager<Receptionist> userManager,RoleManager<IdentityRole<int>> roleManager) : base(clinicDbContext)
        {
            _clinicDbContext = clinicDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        //public async Task<bool> AddReceptionistAndUserAsync(string name, string phone, string email,  string password)
        //{
        //    using var transaction = await _clinicDbContext.Database.BeginTransactionAsync();

        //    try
        //    {
        //        //  Create Receptionist entity 
        //        var receptionist = new Receptionist
        //        {
        //            Name = name,
        //            Phone = phone,
        //            Email = email,
        //            UserName = name
        //        };
        //        //Save receptionist in the database
        //        _clinicDbContext.Receptionists.Add(receptionist);
        //        await _clinicDbContext.SaveChangesAsync();

        //        // Create User Account using Identity
        //        var result = await _userManager.CreateAsync(receptionist, password);
        //        if (!result.Succeeded)
        //        {
        //            return false; 
        //        }

        //        // Step 3: Assign role to receptionist
        //        if (!await _roleManager.RoleExistsAsync("Receptionist"))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole<int>("Receptionist"));
        //        }

        //        await _userManager.AddToRoleAsync(receptionist, "Receptionist");


        //        await _clinicDbContext.SaveChangesAsync();

        //        // Commit transaction
        //        await transaction.CommitAsync();
        //        return true;
        //    }
        //    catch
        //    {
        //        await transaction.RollbackAsync();
        //        return false;
        //    }
        //}
        public async Task<bool> AddReceptionistAndUserAsync(string name, string phone, string email, string password)
        {
            using var transaction = await _clinicDbContext.Database.BeginTransactionAsync();

            try
            {
                // Step 1: Create Receptionist entity (WITHOUT adding to DbContext first)
                var receptionist = new Receptionist
                {
                    Name = name,
                    Phone = phone,
                    Email = email,
                    UserName = name
                };

                // Step 2: Create User Account using Identity (this will handle the ID automatically)
                var result = await _userManager.CreateAsync(receptionist, password);
                if (!result.Succeeded)
                {
                    return false; // If user creation fails, return false
                }

                // Step 3: Assign role to receptionist
                if (!await _roleManager.RoleExistsAsync("Receptionist"))
                {
                    await _roleManager.CreateAsync(new IdentityRole<int>("Receptionist"));
                }

                await _userManager.AddToRoleAsync(receptionist, "Receptionist");

                // Commit transaction
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                return false;
            }
        }

    }
}
