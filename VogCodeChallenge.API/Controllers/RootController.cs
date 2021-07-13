using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Controllers
{
	[Route("/")]
	[ApiController]
	public class RootController : ControllerBase
	{
		[HttpGet(Name = nameof(GetRoot))]
		public IActionResult GetRoot()
		{
			var response = new
			{
				href = Url.Link(nameof(GetRoot), null),
				employees = new
				{
					href = Url.Link(nameof(EmployeesController.GetAllEmployees), null),
				},
				employeesByDepartment = new
				{
					Development = "https://localhost:44319/api/employees/department/001",
					Sales = "https://localhost:44319/api/employees/department/002"
				}
			};

			return Ok(response);
		}
	}
}
