using Microsoft.EntityFrameworkCore;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.DataAccessLayer.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.EntityFramework
{
	public class EfCommentDal : GenericRepository<Comment>, ICommentDal
	{
		public EfCommentDal(SensiveContext context) : base(context)
		{
		}

		public List<Comment> GetCommentsByArticleId(int id)
		{
			var context=new SensiveContext();
			var values=context.Comments.Where(x=>x.ArticleId==id).Include(y=>y.Article).Include(z=>z.AppUser).ToList();
			return values;
		}

		public List<Comment> GetCommentsByAppUserId(int id)
		{
			var context=new SensiveContext();
			var values = context.Comments.Where(x => x.AppUserId == id).Include(x => x.Article).ToList();
			return values;
		}

		public Comment GetCommentById(int commentId, int userId)
		{
			using (var context = new SensiveContext())
			{
				// Yorum ID'si ve kullanıcı ID'si eşleşen veriyi getiriyoruz
				var comment = context.Comments
					.Where(x => x.CommentId == commentId && x.AppUserId == userId) // Yorum ID ve kullanıcı kontrolü
					.Include(x => x.Article) // İlgili makale başlığını yüklemek için
					.FirstOrDefault();
				return comment;
			}
		}
	}
}
