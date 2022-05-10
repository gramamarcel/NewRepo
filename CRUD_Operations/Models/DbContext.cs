using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options) { }

        DbSet<Student> Students { get; set; }

    }
}
