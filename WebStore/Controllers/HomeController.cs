using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
	public class HomeController : Controller
	{
		private readonly List<EmployeeView> employeeList = new List<EmployeeView>
		{
			new EmployeeView{Id = 1, FirsName = "Иван", SurName = "Иванов", Age = 24},
			new EmployeeView{Id = 2, FirsName = "Иван", SurName = "Иванов", Age = 24},
			new EmployeeView{Id = 3, FirsName = "Иван", SurName = "Иванов", Age = 24}
		};

        public IActionResult Index()
        {
            return View(employeeList);
        }

		public IActionResult Details(int id)
		{
			return View(employeeList.FirstOrDefault(x => x.Id == id));
		}
    }
}