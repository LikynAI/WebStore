using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Имя - обязательное для заполнения поле")]
		[Display(Name = "Имя")]
		[StringLength(maximumLength: 32, ErrorMessage = "Имя не может быть длиннее 32 символов", MinimumLength = 2)]
		public string FirstName { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия - обязательное для заполнения поле")]
		[Display(Name = "Фамилия")]
		[StringLength(maximumLength: 32, ErrorMessage = "Фамилия не может быть длиннее 32 символов", MinimumLength = 2)]
		public string SurName { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Возраст - обязательное для заполнения поле")]
		[Display(Name = "Возраст")]
		[Range(minimum: 18, maximum: 100,ErrorMessage = "Пользователь должен быть совершеннолетним")]
		public int Age { get; set; }
	}
}
