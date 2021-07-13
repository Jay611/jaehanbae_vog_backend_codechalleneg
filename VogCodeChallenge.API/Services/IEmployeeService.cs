using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
	public interface IEmployeeService
	{
		public IEnumerable<Employee> GetAll();
		public IList<Employee> ListAll();
		public IEnumerable<Employee> GetEmployeesByDepartment(string departmentId);
	}
}
