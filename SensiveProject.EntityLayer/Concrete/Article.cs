using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.EntityLayer.Concrete
{
	public class Article
	{
		public int ArticleId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CoverImageUrl { get; set; }
		public List<TagCloud> Tags { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }
		public List<Comment> Comments { get; set; }
		public List<ArticleTagCloud> ArticleTagClouds { get; set; }
	}
}
