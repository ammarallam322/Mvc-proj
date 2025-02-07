using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplication1.Models
{
    public class MVCProjectContext :DbContext
    {



        //
            public virtual DbSet<Course> Course { get; set; }   


        public virtual DbSet<CrsReslt>courseResults { get; set; }

        public virtual DbSet<Department>Departments { get; set; }

        public virtual DbSet<Instructor>Instructors { get; set; }

        public virtual DbSet<Trainee>Trainees { get; set; }





        //parameterless consructor that chain on base constructor
        public MVCProjectContext():base()
        {
            
        }

        //parameterless consructor that chain on base constructor to prevent exception during configuring

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options ) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-PQBVQ61\\SQLEXPRESS;Database=MVCProject;Trusted_Connection=True; TrustServerCertificate=True;");

        }











        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // departments 
            #region
            modelBuilder.Entity<Department>().HasData(new Department() { Id = 1, Name = "SD", maneger = "Eng Chrestein" });
            modelBuilder.Entity<Department>().HasData(new Department() { Id = 2, Name = "OS", maneger = "Eng Chrestein" });
            #endregion
            //course 
            #region
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 1, Name = "MVC", degree = 100, minDegree = 60, hours = 30 ,deptId=1 });
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 2, Name = "C#", degree = 100, minDegree = 60, hours = 30 ,deptId=2});
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 3, Name = "Linq", degree = 100, minDegree = 60, hours = 30 ,deptId=1});
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 4, Name = "Entity framework", degree = 100, minDegree = 60, hours = 30 ,deptId=2});
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 5, Name = "js", degree = 100, minDegree = 60, hours = 30 ,deptId=1});
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 6, Name = "css", degree = 100, minDegree = 60, hours = 30 ,deptId=2});
            modelBuilder.Entity<Course>().HasData(new Course() { Id = 7, Name = "network", degree = 100, minDegree = 60, hours = 30 ,deptId=2});
            #endregion
            ////instructors
            #region 
            modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 1, Name = "ammar", imageUrl = "1.gif", address = "tala", salary = 25000, crs_id = 1, deptId = 1 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 2, Name = "allam", imageUrl = "2.png", address = "tala", salary = 25000, crs_id = 1, deptId = 1 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 3, Name = "ali", imageUrl = "4.gif", address = "tala", salary = 25000, crs_id = 1, deptId = 2 });
            modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id = 4, Name = "ahmed", imageUrl = "1.gif", address = "tala", salary = 25000, crs_id = 1, deptId = 2 });
            #endregion


            //adding trainees
            #region
            modelBuilder.Entity<Trainee>().
                HasData(new Trainee() { Id = 1, Name = "ammar allam ", imageUrl="1.gif",address="tala",grade=90,deptId=1});
            modelBuilder.Entity<Trainee>().
                HasData(new Trainee() { Id = 2, Name = "ahmed elsobkey", imageUrl="1.gif",address="elbagor",grade=49,deptId=1});
            modelBuilder.Entity<Trainee>().
             HasData(new Trainee() { Id = 3, Name = "ammar allam ", imageUrl = "1.gif", address = "tala", grade = 90, deptId = 1 });
            modelBuilder.Entity<Trainee>().
                HasData(new Trainee() { Id = 4, Name = "ahmed elsobkey", imageUrl = "1.gif", address = "elbagor", grade = 49, deptId = 1 });
            modelBuilder.Entity<Trainee>().
                         HasData(new Trainee() { Id = 5, Name = "ammar allam ", imageUrl = "1.gif", address = "tala", grade = 90, deptId = 1 });
            modelBuilder.Entity<Trainee>().
                HasData(new Trainee() { Id = 6, Name = "ahmed elsobkey", imageUrl = "1.gif", address = "elbagor", grade = 49, deptId = 1 });
            modelBuilder.Entity<Trainee>().
                         HasData(new Trainee() { Id = 7, Name = "ammar allam ", imageUrl = "1.gif", address = "tala", grade = 90, deptId = 1 });
            modelBuilder.Entity<Trainee>().
                HasData(new Trainee() { Id = 8, Name = "ahmed elsobkey", imageUrl = "1.gif", address = "elbagor", grade = 49, deptId = 1 });


            #endregion


            //addding course result 
            #region

            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id=1,degree="90", Crs_id=1,trainee_id=1});
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id=2,degree="49", Crs_id=1,trainee_id=2});

            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 10, degree = "90", Crs_id = 1, trainee_id = 3 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 3, degree = "90", Crs_id = 2, trainee_id = 3 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 4, degree = "49", Crs_id = 2, trainee_id = 4 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 5, degree = "90", Crs_id = 3, trainee_id = 5 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 6, degree = "49", Crs_id = 3, trainee_id = 6 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 7, degree = "90", Crs_id = 4, trainee_id = 7 });
            modelBuilder.Entity<CrsReslt>().HasData(new CrsReslt() { id = 8, degree = "49", Crs_id = 4, trainee_id = 8 });

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
