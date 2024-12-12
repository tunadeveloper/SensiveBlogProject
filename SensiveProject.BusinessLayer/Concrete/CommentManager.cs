﻿using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		private readonly ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void TDelete(int id)
		{
			_commentDal.Delete(id);
		}

		public List<Comment> TGetAll()
		{
			return _commentDal.GetAll();
		}

		public Comment TGetById(int id)
		{
			return _commentDal.GetById(id);
		}

		public Comment TGetCommentById(int commentId, int userId)
		{
			return _commentDal.GetCommentById(commentId, userId);
		}

		public List<Comment> TGetCommentsByAppUserId(int id)
		{
			return _commentDal.GetCommentsByAppUserId(id);
		}

		public List<Comment> TGetCommentsByArticleId(int id)
		{
			return _commentDal.GetCommentsByArticleId(id);
		}

		public void TInsert(Comment entity)
		{
			_commentDal.Insert(entity);
		}

		public void TUpdate(Comment entity)
		{
			_commentDal.Update(entity);
		}
	}
}
