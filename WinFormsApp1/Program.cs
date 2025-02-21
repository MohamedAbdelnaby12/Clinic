using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Repository.Implementation;
using Clinic.BLL.Services;
using Clinic.BLL.Services.Abstract;
using Clinic.DAL;
using Clinic.DAL.Entities;
using Clinic.DAL.GenericRepo;
using Clinic.DAL.GenericRepository;
using Clinic.DAL.Repository.Abstract;
using Clinic.DAL.Repository.Implementation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static ServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();

            #region Initialize DI Container
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            //Seed Data
            await SeedAdminUser(ServiceProvider);
            #endregion

            #region Run Application With DI
            var loginForm = ServiceProvider.GetRequiredService<login>();
            Application.Run(loginForm);
            //Application.Run(new login()); 
            #endregion

        }
        private  static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ClinicDbContext>(options =>
            options.UseSqlServer("server=.;database=Clinic;Trusted_connection=True;TrustServerCertificate=True;"));

            services.AddIdentityCore<Receptionist>()
            .AddRoles<IdentityRole<int>>()
            .AddEntityFrameworkStores<ClinicDbContext>();

            services.AddScoped<UserManager<Receptionist>>();
            // services.AddScoped<SignInManager<Receptionist>>();
            services.AddScoped<RoleManager<IdentityRole<int>>>();


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #region Register DAL Repos
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IReceptionistRepository, ReceptionistRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            #endregion

            #region Register Services
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IReceptionistService, ReceptionistService>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IScheduleService, ScheduleService>();
           

            #endregion

            #region Register Forms
            services.AddScoped<UpdatePatient>();
            services.AddScoped<Doctor>();
            services.AddScoped<AddDoctor>();
            services.AddScoped<Home>();
            services.AddScoped<login>();
            services.AddScoped<Schedule>();
            services.AddScoped<UpdateDoctor>();
            #endregion



            //services.AddScoped<MainForm>();
        }
        private static async Task SeedAdminUser(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<Receptionist>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            string adminEmail = "admin@gmail.com";
            string adminUsername = "admin";
            string adminPassword = "Admin123.";

            // Check if Admin role exists, if not, create it
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole<int> { Name = "Admin" });
            }

            // Check if Admin user exists
            var adminUser = await userManager.FindByNameAsync(adminUsername);
            if (adminUser == null)
            {
                adminUser = new Receptionist
                {
                    UserName = adminUsername,
                    Email = adminEmail,
                    Name = "Administrator",
                    Phone = "1234567890",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                    Console.WriteLine("Admin user created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create admin user.");
                }
            }
            else
            {
                Console.WriteLine("Admin user already exists.");
            }
        }
    }
}