using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMS.Models;
using SMS.Models.Academics;
using SMS.Models.Inventory;
using SMS.Models.Leave;
using SMS.Models.Setup;
using SMS.Models.TimeTable;
using SMS.Models.Transport;
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

        public virtual DbSet<ClassTimeTable> ClassTimeTable { get; set; }

        //end Leave tables

        #region "Inventory"

        public virtual DbSet<InventoryDefect> InventoryDefects { get; set; }
        public virtual DbSet<InventoryItemType> InventoryItemTypes { get; set; }
        public virtual DbSet<InventoryItemUsageArea> InventoryItemUsageAreas { get; set; }
        public virtual DbSet<Inventory> Inventorys { get; set; }

        #endregion

        #region "Transport"
        public virtual DbSet<BusType> BusTypes { get; set; }
        public virtual DbSet<BusesAndDriver> BusesAndDrivers { get; set; }
        public virtual DbSet<BusTrip> BusTrips { get; set; }
        public virtual DbSet<NotificationSpan> NotificationSpans { get; set; }
        #endregion "Transport"

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