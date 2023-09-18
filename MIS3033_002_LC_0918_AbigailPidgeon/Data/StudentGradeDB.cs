using Microsoft.EntityFrameworkCore;

namespace a
{
    class StudentGradeDB:DbContext
    {
        public DbSet<StudentGrade> StugradesTbl { get; set; } // this is a table
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source = stugrades.db"); 
        }
    }
}
