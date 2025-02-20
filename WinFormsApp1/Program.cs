using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Repository.Implementation;
using Clinic.BLL.Services;
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
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();

            #region Initialize DI Container
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            #endregion

            #region Run Application With DI
            var loginForm = ServiceProvider.GetRequiredService<login>();
            Application.Run(loginForm);
            //Application.Run(new login()); 
            #endregion

        }
        private static void ConfigureServices(ServiceCollection services)
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
            #endregion

            #region Register Forms
            services.AddScoped<UpdatePatient>();
            #endregion

            services.AddScoped<login>();


            //services.AddScoped<MainForm>();
        }
    }
}