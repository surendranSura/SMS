using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMS.Models;
using SMS.Models.Academics;
using SMS.Models.Leave;
using SMS.Models.Setup;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public class MysqlDataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<AcademicClass> AcademicClasses { get; set; }

        public virtual DbSet<AcademicClassSubject> AcademicClassSubjects { get; set; }

        public virtual DbSet<LessonPlan> LessonPlans { get; set; }


        //leave tables

        public virtual DbSet<StudentLeave> StudentLeaves { get; set; }

        public virtual DbSet<StaffLeave> StaffLeaves { get; set; }

        //end Leave tables

        private readonly IConfiguration Configuration;

        public MysqlDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseMySQL(Configuration.GetConnectionString("WebApiDatabaseMySQL_Dev"));
            //options.
        }
    }
}