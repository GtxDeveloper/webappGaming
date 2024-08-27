using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Entities
{
	public class User
	{
		public int Id { get; set; }

		[Required(ErrorMessage ="Заполните Login")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Заполните Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Заполните Email")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string Email { get; set; }

		[DataType(DataType.Date)]
		[ValidateNever]
		public DateTime DateRegister { get; set; } = DateTime.Now;

		public int RoleId { get; set; } = 1;

		public Role Role	{ get; set; }
	}
}