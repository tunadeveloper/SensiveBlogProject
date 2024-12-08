using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.Abstract
{
    public interface ICommentDal :IGenericDal<Comment>
    {
       List<Comment> GetCommentListByArticleId(int id);
       List<Comment> GetCommentListByAppUserId(int id);
    }
}
