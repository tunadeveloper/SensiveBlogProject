using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
	public class ArticleTagCloudManager : IArticleTagCloudService
	{
		private readonly IArticleTagCloudDal _articleTagDal;

		public ArticleTagCloudManager(IArticleTagCloudDal articleTagDal)
		{
			_articleTagDal = articleTagDal;
		}

		public void TDelete(int id)
		{
			throw new NotImplementedException();
		}

		public List<ArticleTagCloud> TGetAll()
		{
			throw new NotImplementedException();
		}

		public List<ArticleTagCloud> TGetAllByArticleId(int articleId)
		{
			return _articleTagDal.GetAllByArticleId(articleId);
		}

		public ArticleTagCloud TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(ArticleTagCloud entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ArticleTagCloud entity)
		{
			throw new NotImplementedException();
		}
	}
}
