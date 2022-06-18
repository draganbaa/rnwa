using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCCollegeDB.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<faculty> faculty { get; set; }
        public virtual DbSet<marks> marks { get; set; }
        public virtual DbSet<students> students { get; set; }
        public virtual DbSet<subjects> subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<departments>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.faculty1)
                .WithRequired(e => e.departments1)
                .HasForeignKey(e => e.department_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.students)
                .WithOptional(e => e.departments)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.subjects)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.department_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<faculty>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<faculty>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<faculty>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<faculty>()
                .HasMany(e => e.departments)
                .WithOptional(e => e.faculty)
                .HasForeignKey(e => e.hod_id);

            modelBuilder.Entity<faculty>()
                .HasMany(e => e.subjects)
                .WithRequired(e => e.faculty)
                .HasForeignKey(e => e.faculty_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<students>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<students>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<students>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<students>()
                .HasMany(e => e.marks)
                .WithRequired(e => e.students)
                .HasForeignKey(e => e.student_roll_num)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<subjects>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<subjects>()
                .HasMany(e => e.marks)
                .WithRequired(e => e.subjects)
                .HasForeignKey(e => e.subject_id)
                .WillCascadeOnDelete(false);
        }
    }
}
