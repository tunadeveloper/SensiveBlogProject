using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> TGetCommentsByArticleId(int id);
		List<Comment> TGetCommentsByAppUserId(int id);
		Comment TGetCommentById(int commentId, int userId);
	}
}
