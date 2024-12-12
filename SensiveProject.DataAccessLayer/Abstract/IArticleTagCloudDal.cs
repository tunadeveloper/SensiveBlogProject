using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.Abstract
{
	public interface IArticleTagCloudDal : IGenericDal<ArticleTagCloud>
	{
		List<ArticleTagCloud> GetAllByArticleId(int articleId);
	}
}
