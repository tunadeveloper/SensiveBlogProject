using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _CommentDal;

        public CommentManager(ICommentDal CommentDal)
        {
            _CommentDal = CommentDal;
        }

        public void TDelete(int id)
        {
            _CommentDal.Delete(id);
        }

        public List<Comment> TGetAll()
        {
            return _CommentDal.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _CommentDal.GetById(id);
        }

        public List<Comment> TGetCommentListByAppUserId(int id)
        {
            return _CommentDal.GetCommentListByAppUserId(id);
        }

        public List<Comment> TGetCommentListByArticleId(int id)
        {
            return _CommentDal.GetCommentListByArticleId(id);
        }

        public void TInsert(Comment entity)
        {
            _CommentDal.Insert(entity);

        }

        public void TUpdate(Comment entity)
        {
            _CommentDal.Update(entity);
        }
    }
}
