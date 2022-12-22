using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employemanagement.Api.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
		{

		}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentId = 1, DepartmentName = "IT" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentId = 2, DepartmentName = "HR" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentId = 3, DepartmentName = "Payroll" });
			modelBuilder.Entity<Department>().HasData(
				new Department { DepartmentId = 4, DepartmentName = "Admin" });

			modelBuilder.Entity<Employee>().HasData(
				new Employee { EmployeeId = 1, 
				FirstName="John",
				LastName="Hastings",
				Email="Johnhastings@gmail.com",
				DOB=new DateTime(1980,10,5),
				Gender=Gender.Male,
				DepartmentId =1 ,
				PhotoPath="images/sam.png"}
				
				);
			modelBuilder.Entity<Employee>().HasData(
				new Employee
				{
					EmployeeId = 2,
					FirstName = "Sam",
					LastName = "Hastings",
					Email = "Johnhastings@gmail.com",
					DOB = new DateTime(1980, 10, 5),
					Gender = Gender.Male,
					DepartmentId = 2,
					PhotoPath = "images/sam.png"
				}

				);
		}
	}
}
