using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Services
{
	public class InMemoryEmployeeService : IEmployeesService
	{
		private readonly List<EmployeeViewModel> _employees;

		public InMemoryEmployeeService()
		{
			_employees = new List<EmployeeViewModel>
			{
				new EmployeeViewModel
				{
					Id = 1,
					FirstName = "Иван",
					SurName = "Иванов",
					Age = 27
				},
				new EmployeeViewModel
				{
					Id = 1,
					FirstName = "Иван",
					SurName = "Иванов",
					Age = 27
				},
				new EmployeeViewModel
				{
					Id = 1,
					FirstName = "Иван",
					SurName = "Иванов",
					Age = 27
				}
			};
		}

		public void AddNew(EmployeeViewModel model)
		{
			model.Id = _employees.Max(x => x.Id) + 1;
			_employees.Add(model);
		}

		public void Commit()
		{
		}

		public void Delete(int id)
		{
			var employee = GetById(id);
			if (employee != null)
			{
				_employees.Remove(employee);
			}
		}

		public IEnumerable<EmployeeViewModel> GetAll()
		{
			return _employees;
		}

		public EmployeeViewModel GetById(int id)
		{
			return _employees.FirstOrDefault(x => x.Id == id);
		}
	}
}
