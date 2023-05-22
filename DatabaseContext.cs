using learningRelationInEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace learningRelationInEFCore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }
}
