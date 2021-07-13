using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API
{
	public static class SeedData
	{
		public static async Task InitializeAsync(IServiceProvider services)
		{
			await AddTestData(services.GetRequiredService<EmployeeApiDbContext>());
		}
		public static async Task AddTestData(EmployeeApiDbContext context)
		{
			if (context.Employees.Any() || context.Departments.Any())
			{
				// Alread has data
				return;
			}

			var emp1 = new Employee
			{
				Id = Guid.Parse("301df04d-8679-4b1b-ab92-0a586ae53de1"),
				FirstName = "Jaehan",
				LastName = "Bae",
				JobTitle = "Developer",
				Address = "72 Confederation Dr., Toronto, Canada"
			};

			var emp2 = new Employee
			{
				Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e91959e2"),
				FirstName = "Yuki",
				LastName = "Kakazu",
				JobTitle = "Project manager",
				Address = "941 Progress Ave, Toronto, Canada"
			};

			var emp3 = new Employee
			{
				Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e91959e3"),
				FirstName = "June",
				LastName = "Chen",
				JobTitle = "Sales manager",
				Address = "941 Progress Ave, Toronto, Canada"
			};

			var dep1 = new Department
			{
				Id = "001",
				Name = "Development",
				Address = "72 Confederation Dr., Toronto, Canada",
			};

			dep1.Employees.Add(emp1);
			dep1.Employees.Add(emp2);
			emp1.DepartmentId = dep1.Id;
			emp2.DepartmentId = dep1.Id;

			var dep2 = new Department
			{
				Id = "002",
				Name = "Sales",
				Address = "72 Confederation Dr., Toronto, Canada",
			};

			dep2.Employees.Add(emp3);
			emp3.DepartmentId = dep2.Id;

			context.Departments.AddRange(dep1, dep2);
			context.Employees.AddRange(emp1, emp2, emp3);

			await context.SaveChangesAsync();
		}
	}
}
