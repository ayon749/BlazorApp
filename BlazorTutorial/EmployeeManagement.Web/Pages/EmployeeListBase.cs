using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
	public class EmployeeListBase:ComponentBase
	{
		public IEnumerable<Employee> Employees { get; set; }
		protected override async Task OnInitializedAsync()
		{
			await Task.Run(LoadEmployees);
			
		}
		private void LoadEmployees()
		{
			System.Threading.Thread.Sleep(3000);
			Employee e1 = new Employee
			{
				EmployeeId = 1,
				FirstName = "Mahedi",
				LastName = "Hasan",
				Email = "mahedihasn@gmail.com",
				DOB = new DateTime(1982, 12, 12),
				Gender = Gender.Male,
				Department = new Department { DepartmentId = 1, DepartmentName = "CSE" },
				PhotoPath="images/sam.png"
			};
			Employee e2 = new Employee
			{
				EmployeeId = 1,
				FirstName = "Mahedi",
				LastName = "Hasan",
				Email = "mahedihasn@gmail.com",
				DOB = new DateTime(1982, 12, 12),
				Gender = Gender.Male,
				Department = new Department { DepartmentId = 1, DepartmentName = "CSE" },
				PhotoPath = "images/sam.png"
			};
			Employee e3 = new Employee
			{
				EmployeeId = 1,
				FirstName = "Mahedi",
				LastName = "Hasan",
				Email = "mahedihasn@gmail.com",
				DOB = new DateTime(1982, 12, 12),
				Gender = Gender.Male,
				Department = new Department { DepartmentId = 1, DepartmentName = "CSE" },
				PhotoPath = "images/sam.png"
			};
			Employees = new List<Employee> { e1, e2, e3 };
		}
	}
}
