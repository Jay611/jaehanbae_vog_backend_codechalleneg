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

		public IEnumerable<Employee> GetEmployeesByDepartment(string departmentId)
		{
			var employees = _context.Employees.Where(e => e.DepartmentId == departmentId).AsEnumerable<Employee>();

			if(employees == null)
			{
				return null;
			}

			return employees;
		}

		public IList<Employee> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
