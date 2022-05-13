using Microsoft.EntityFrameworkCore;

namespace School
{
    public class Context : DbContext
    {
        public DbSet<TblStudent> tblStudents { get; set; }

        public DbSet<TblTeacher> tblTeachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db
                .UseSqlServer("Data source =. ; initial Catalog = Tablemvc; integrated Security = true ;");
        }
    }
}
