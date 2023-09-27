using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<TeacherPupil> TeacherPupils { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherPupil>()
            .HasKey(tp => new { tp.TeacherId, tp.PupilId });

            modelBuilder.Entity<TeacherPupil>()
                .HasOne(tp => tp.Teacher)
                .WithMany(t => t.TeacherPupils)
                .HasForeignKey(tp => tp.TeacherId);

            modelBuilder.Entity<TeacherPupil>()
                .HasOne(tp => tp.Pupil)
                .WithMany(p => p.TeacherPupils)
                .HasForeignKey(tp => tp.PupilId);
        }
    }
}
