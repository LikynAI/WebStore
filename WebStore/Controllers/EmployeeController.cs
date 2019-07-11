using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
	public class EmployeeController : Controller
	{
		public IEmployeesService _employees { get; }

		public EmployeeController(IEmployeesService employees)
		{
			_employees = employees;
		}


		public IActionResult Index()
        {
			return View(_employees.GetAll());
		}

		public IActionResult Details(int id)
		{
			var employee = _employees.GetById(id);

			if (employee == null)
				return NotFound();
			else
			{
				return View(employee);
			}
		}

		[HttpGet]
		public IActionResult Edit(int? id)
		{
			if (!id.HasValue)
			{
				return View(new EmployeeViewModel());
			}

			EmployeeViewModel model = _employees.GetById(id.Value);
			if (model == null)
			{
				return NotFound();
			}
			else
			{
				return View(model);
			}
		}

		[HttpPost]
		public IActionResult Edit(EmployeeViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			if (model.Id > 0)
			{
				var dbItem = _employees.GetById(model.Id);

				if (ReferenceEquals(dbItem, null))
					return NotFound();

				dbItem.FirstName = model.FirstName;
				dbItem.SurName = model.SurName;
				dbItem.Age = model.Age;
			}
			else 
			{
				_employees.AddNew(model);
			}

			_employees.Commit();

			return RedirectToAction(nameof(Index));
		}

		[Route("delete/{id}")]
		public IActionResult Delete(int id)
		{
			_employees.Delete(id);

			return RedirectToAction(nameof(Index));
		}

	}
}