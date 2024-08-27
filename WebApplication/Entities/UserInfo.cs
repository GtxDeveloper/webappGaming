using System.ComponentModel.DataAnnotations;

namespace WebApplication.Entities
{
	public class UserInfo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Заполните Name")]
		[DataType(DataType.Text)]
		public string Name { get; set; }


		[Required(ErrorMessage = "Заполните Surname")]
		[DataType(DataType.Text)]
		public string Surname { get; set; }


		[Required(ErrorMessage = "Заполните Avatar")]
		[DataType(DataType.ImageUrl)]
		public string Avatar { get; set; } = "/admin/media/avatars/blank.png";

		[Required(ErrorMessage = "Заполните PhoneNumber")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Заполните Info")]
		[DataType(DataType.Text)]
		public string Info { get; set; }

		public string Address { get; set; }
		public string JobTitle { get; set; }
		public string CompanyTitle { get; set; }
		public string CompanySite { get; set; }
		public string Country { get; set; }

		public int UserId { get; set; }

		public User User { get; set; }
	}
}
