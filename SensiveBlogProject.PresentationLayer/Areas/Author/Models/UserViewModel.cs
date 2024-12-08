namespace BlogProject.PresentationLayer.Areas.Author.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
        public IFormFile Image { get; set; } // Yeni resim yüklemek için

        public string ImageUrl { get; set; }

        public string Password { get; set; }

       
    }
}
