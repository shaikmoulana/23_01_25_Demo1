using Microsoft.EntityFrameworkCore;
using Sample1.Models;
using System.Data;

namespace Sample1.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Departments> TblDepartment { get; set; }
        public DbSet<Designations> TblDesignation { get; set; }
        /*public DbSet<Employee> TblEmployee { get; set; }
        public DbSet<Role> TblRole { get; set; }
        public DbSet<Blogs> TblBlogs { get; set; }
        public DbSet<Technology> TblTechnology { get; set; }
        public DbSet<EmployeeTechnology> TblEmployeeTechnology { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //----------3rd table_Employee------------------------------------
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Designation)
            .WithMany(d => d.Employee)
            .HasForeignKey(e => e.DesignationId);

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employee)
            .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Roles)
            .WithMany(d => d.Employee)
            .HasForeignKey(e => e.Role);

            modelBuilder.Entity<Employee>()
            .HasOne(e => e.ReportingToEmployee)
            .WithMany(d => d.Subordinates)
            .HasForeignKey(e => e.ReportingTo);


            //----------4th table Technology------------------------------------
            modelBuilder.Entity<Technology>()
                        .HasOne(t => t.Department)
                        .WithMany(d => d.Technology)
                        .HasForeignKey(t => t.DepartmentId);



            //----------5th table EmployeeTechnology------------------------------------
            modelBuilder.Entity<EmployeeTechnology>()
                        .HasOne(et => et.Technologies)
                        .WithMany(t => t.EmployeeTechnology)
                        .HasForeignKey(et => et.Technology);

            modelBuilder.Entity<EmployeeTechnology>()
            .HasOne(et => et.Employee)
            .WithMany(t => t.Technology)
            .HasForeignKey(et => et.EmployeeID);
        }*/
    }
}
