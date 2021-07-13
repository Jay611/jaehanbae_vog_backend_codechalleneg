using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private readonly EmployeeApiDbContext _context;

		public EmployeesController(EmployeeApiDbContext context)
		{
			_context = context;
		}

		IEnumerable<Employee> GetAll()
		{
			return _context.Employees;
		}

		IList<Employee> ListAll()
		{
			return _context.Employees.ToList();
		}

		// Get /employees
		[HttpGet(Name = nameof(GetAllEmployees))]
		[ProducesResponseType(404)]
		public ActionResult<Employee> GetAllEmployees()
		{
			var entity = GetAll();
			if(entity == null)
			{
				return NotFound();
			}

			return Ok(entity);
		}



	}
}
