using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly EmployeeApiDbContext _context;

		public EmployeeService(EmployeeApiDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Employee> GetAll()
		{
			if (_context.Employees == null)
			{
				return null;
			}

			return _context.Employees;
		}

		public IList<Employee> ListAll()
		{
			if (_context.Employees == null)
			{
				return null;
			}

			return _context.Employees.ToList();
		}

		public IEnumerable<Employee> GetEmployeesByDepartment(string departmentId)
		{
			var entity = _context.Employees.Where(e => e.DepartmentId==departmentId).AsEnumerable<Employee>();

			if (entity == null)
			{
				return null;
			}

			return entity;
		}
	}
}
