using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.EntityLayer.Concrete
{
	public class ArticleTagCloud
	{
		public int Id { get; set; } // Primary key
		public int ArticleId { get; set; }
		public Article Article { get; set; }

		public int TagCloudId { get; set; }
		public TagCloud TagCloud { get; set; }
	}
}
