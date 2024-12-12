using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Areas.Author.Models
{
	public class ArticleCategoryViewModel
	{
		public Article Article { get; set; }
		public Category Category { get; set; }
		public List<SelectListItem> CategoryList { get; set; }
	}

}
