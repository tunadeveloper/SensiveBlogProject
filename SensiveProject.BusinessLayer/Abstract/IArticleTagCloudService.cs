using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Abstract
{
	public interface IArticleTagCloudService : IGenericService<ArticleTagCloud>
	{
		public List<ArticleTagCloud> TGetAllByArticleId(int articleId);
	}
}
