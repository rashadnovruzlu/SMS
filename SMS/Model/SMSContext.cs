namespace SMS.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SMSContext : DbContext
    {
        public SMSContext()
            : base("name=SMSContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Exam_Result> Exam_Result { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Student_Information> Student_Information { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Exam_Result)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Student_Information)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sex>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sex>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Sex)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Exam_Result)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student_Information)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student_Information>()
                .Property(e => e.PIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student_Information>()
                .Property(e => e.CN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student_Information>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Exam)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
