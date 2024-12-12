namespace SensiveProject.PresentationLayer.Areas.Author.Models
{
	public class UserEditViewModel
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string AuthorDetail { get; set; }

		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string ImageUrl { get; set; }
		public IFormFile Image { get; set; }
	}
}
