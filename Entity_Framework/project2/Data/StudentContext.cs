using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project2.Models;

namespace project2.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<project2.Models.Student> Student { get; set; } = default!;

        public DbSet<project2.Models.Course>? Course { get; set; }

        public DbSet<project2.Models.Enrollment>? Enrollment { get; set; }
    }
}
