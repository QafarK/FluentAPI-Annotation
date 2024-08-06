using FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.DB;

internal class AcademyContext : DbContext
{
    public AcademyContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Facultie> Faculties { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Academy;Integrated Security=SSPI;").UseAllCheckConstraints();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Group
        modelBuilder.Entity<Group>()
            .Property(x => x.GroupId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Group>()
            .Property(x => x.GroupId)
            .IsRequired()
            .HasMaxLength(10);

        modelBuilder.Entity<Group>()
    .Property(x => x.Rating)
    .HasColumnType("integer");

        modelBuilder.Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_Group_Rating", "Rating >= 0 AND Rating<= 5"))
            .ToTable(x => x.HasCheckConstraint("CK_Group_Year", "Year >= 1 AND Year <= 4"));
        #endregion

        #region Department
        modelBuilder.Entity<Department>()
            .Property(x => x.DepartmentId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Department>()
    .Property(x => x.Name)
    .IsRequired()
    .HasMaxLength(100);


        modelBuilder.Entity<Department>()
    .Property(x => x.Financing)
    .HasColumnType("money")
    .HasDefaultValue(0);

        modelBuilder.Entity<Department>()
          .ToTable(x => x.HasCheckConstraint("CK_Department_Financing", "Financing >= 0"));
        #endregion

        #region Facultie
        modelBuilder.Entity<Facultie>()
            .HasKey(x => x.FacultyId);

        modelBuilder.Entity<Facultie>()
    .Property(x => x.FacultyId)
    .HasColumnName("Id")
    .ValueGeneratedOnAdd();

        modelBuilder.Entity<Facultie>()
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
        #endregion

        #region Teacher

        modelBuilder.Entity<Teacher>()
            .Property(x => x.TeacherId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Teacher>()
            .Property(x => x.FirstName)
            .HasColumnName("Name")
            .IsRequired();

        modelBuilder.Entity<Teacher>()
    .Property(x => x.LastName)
    .HasColumnName("Surname")
    .IsRequired();


        modelBuilder.Entity<Teacher>()
    .Property(x => x.Premium)
    .HasColumnType("money")
    .HasDefaultValue(0);

        modelBuilder.Entity<Teacher>()
       .ToTable(x => x.HasCheckConstraint("CK_Teacher_Premium", "Premium >= 0"));


        modelBuilder.Entity<Teacher>()
    .Property(x => x.EmploymentDate)
    .HasColumnType("datetime2");


        modelBuilder.Entity<Teacher>()
       .ToTable(x => x.HasCheckConstraint("CK_Teacher_EmploymentDate", "EmploymentDate >= '1990-01-01'"));

        modelBuilder.Entity<Teacher>()
                .Property(x => x.Salary)
                .HasColumnType("money")
                .HasDefaultValue(0);

        modelBuilder.Entity<Teacher>()
      .ToTable(x => x.HasCheckConstraint("CK_Teacher_Salary", "Salary >= 0"));
        #endregion

        #region Student

        modelBuilder.Entity<Student>()
            .Property(x => x.StudentId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Student>()
    .Property(x => x.FirstName)
    .HasColumnName("Name")
    .IsRequired()
    .HasMaxLength(int.MaxValue);

        modelBuilder.Entity<Student>()
    .Property(x => x.LastName)
    .HasColumnName("Surname")
    .IsRequired()
    .HasMaxLength(int.MaxValue);
        #endregion
    }
}
