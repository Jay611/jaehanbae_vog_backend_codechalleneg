using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private readonly IEmployeeService _employeeService;

		public EmployeesController(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		// Get /employees
		[HttpGet(Name = nameof(GetAllEmployees))]
		[ProducesResponseType(404)]
		public ActionResult<Employee> GetAllEmployees()
		{
			var employees = _employeeService.GetAll();

			if (employees == null) return NotFound();

			return Ok(employees);
		}

		// Get /employees/department/{departmentId}
		[HttpGet("department/{departmentId}", Name = nameof(GetEmployeesByDepartment))]
		[ProducesResponseType(404)]
		public ActionResult<Employee> GetEmployeesByDepartment(string departmentId)
		{
			var employees = _employeeService.GetEmployeesByDepartment(departmentId);

			if (employees == null) return NotFound();

			return Ok(employees);
		}
	}
}
