using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Repository.ImodelRepository;
using WebApplication1.Repository.modelRepositories;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)  
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //adding settings related to UseSession middleware
            builder.Services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            //adding my context to the builder configuation

            builder.Services.AddDbContext<MVCProjectContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));

            });


            //adding register services make controller factory be able to resolve the injection

            //builder.Services.AddScoped<ICourseRepository, CourseRepository>();

            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            //builder.Services.AddScoped<ICraResultRepository, CraResultRepository>();

            //builder.Services.AddScoped<IinstructorRepository, instructorRepository>();

            //builder.Services.AddScoped<ITraineeRepository, TraineeRepository>();


            //register of generic repository
            builder.Services.AddScoped(typeof(IRepositoryGeneric<>), typeof(RepositoryGeneric<>));

            // regester of identity and simplyfing password constraints
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<MVCProjectContext>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            // adding middle ware for session 
            app.UseSession();

            app.UseAuthorization();

            app.MapStaticAssets();//???????????????????????????/
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
